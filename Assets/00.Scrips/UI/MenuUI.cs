using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Button statusBtn;
    public Button Inventory;

    UIManager uiManager;

    private void Awake()
    {
        statusBtn.onClick.AddListener(ClickStatusButton);
        Inventory.onClick.AddListener(ClickInvenButton);
    }
    // Start is called before the first frame update
    void Start()
    {
        uiManager = GetComponentInParent<UIManager>();
    }

    // Update is called once per frame
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
