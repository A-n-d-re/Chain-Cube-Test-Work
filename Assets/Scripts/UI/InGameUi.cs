using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Game.UI;

public class InGameUi : MenuWindow
{
    [SerializeField] private InGameUIManager inGameUIManager;
    [SerializeField] private Button settingButton;
    [SerializeField] private TextMeshProUGUI currScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    public override void Init(bool isOpen = false)
    {
        base.Init(isOpen);
        settingButton.onClick.AddListener(OpenSetting);
    }

    private void OpenSetting() => inGameUIManager.OpenSetting();

    public void SetScore(int score, int highScore)
    {
        currScoreText.text = score.ToString();
        highScoreText.text = $"High score: {highScore}";
    }
}