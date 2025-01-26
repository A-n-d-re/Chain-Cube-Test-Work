using TMPro;
using UnityEngine;
using YG;

public class LanguageDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI languageText;

    private void Start()
    {
        if (!YG2.isSDKEnabled)
        {
            YG2.StartInit();
        }

        SetLanguageText();
    }

    private void SetLanguageText()
    {
        string languageCode = GetLanguageCode(YG2.envir.language);

        languageText.text = languageCode;
    }

    private string GetLanguageCode(string yandexLanguage)
    {
        return yandexLanguage.ToUpper();
    }

}
