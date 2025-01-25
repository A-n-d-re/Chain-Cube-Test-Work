using TMPro;
using UnityEngine;

public class LanguageDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI languageText;

    private void Start()
    {
        languageText.text = GetLanguageCode(Application.systemLanguage);
    }

    private string GetLanguageCode(SystemLanguage systemLanguage)
    {
        switch (systemLanguage)
        {
            case SystemLanguage.Russian: return "RU";
            case SystemLanguage.English: return "EN";
            case SystemLanguage.Spanish: return "ES";
            case SystemLanguage.French: return "FR";
            case SystemLanguage.German: return "DE";
            case SystemLanguage.ChineseSimplified: return "ZH";
            default: return "EN";
        }
    }
}