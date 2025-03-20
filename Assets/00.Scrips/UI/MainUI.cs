using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [Header("PlayerInfo")]
    [SerializeField] TextMeshProUGUI styleTxt;
    [SerializeField] TextMeshProUGUI nameTxt;
    [SerializeField] TextMeshProUGUI lvTxt;
    [SerializeField] TextMeshProUGUI expTxt;
    [SerializeField] Image expBar;
    [SerializeField] TextMeshProUGUI descripTxt;

    [Header("GoldInfo")]
    [SerializeField] TextMeshProUGUI goldTxt;

    Player player;

    private void Start()
    {
        player = GameManager.Instance.Player;
        SetPlayerInfo();
    }

    private void SetPlayerInfo()
    {
        styleTxt.text = player.style;
        nameTxt.text = player.userName;
        lvTxt.text = player.level.ToString();
        expTxt.text = $"{player.curExp} / {player.maxExp}";
        expBar.fillAmount = ((float)player.curExp / player.maxExp);
        descripTxt.text = player.decrip;
        goldTxt.text = UtiltiyClass.UpdateGold(player.gold);
    }


}
