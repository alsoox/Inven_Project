using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStatus : UIBasePopup
{
    [SerializeField] TextMeshProUGUI attackTxt;
    [SerializeField] TextMeshProUGUI deffenseTxt;
    [SerializeField] TextMeshProUGUI healthTxt;
    [SerializeField] TextMeshProUGUI criticalTxt;

    Player player;

    private void Start()
    {
        player = GameManager.Instance.Player;
        GameManager.Instance.UIManager.invenUI.equip += SetStatusUI;
        SetStatusUI();
    }

    private void SetStatusUI()
    {
        attackTxt.text = player.powerValue.ToString();
        deffenseTxt.text = player.armorValue.ToString();
        healthTxt.text = player.maxHealth.ToString();
        criticalTxt.text = player.critical.ToString();
    }
}
