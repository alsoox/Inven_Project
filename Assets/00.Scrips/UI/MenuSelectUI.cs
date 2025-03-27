using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelectUI : MonoBehaviour
{
    public Button statusBtn;
    public Button Inventory;

    UIManager uiManager;

    private void Awake()
    {
        statusBtn.onClick.AddListener(ClickStatusButton);
        Inventory.onClick.AddListener(ClickInvenButton);
    }
    void Start()
    {
        uiManager = GetComponentInParent<UIManager>();
    }

    void ClickStatusButton()
    {
        gameObject.SetActive(false);
        uiManager.statusUI.OpenUI();
        uiManager.backBtn.gameObject.SetActive(true);
    }

    void ClickInvenButton()
    {
        gameObject.SetActive(false);
        uiManager.invenUI.OpenUI();
        uiManager.backBtn.gameObject.SetActive(true);
    }
}
