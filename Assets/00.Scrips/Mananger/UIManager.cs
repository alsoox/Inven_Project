using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button backBtn;

    
    public MenuSelectUI menuUI;
    public UIStatus statusUI;
    public UIInventory invenUI;

    private GameManager gameManager;
    public void Init(GameManager _gameManager)
    {
        gameManager = _gameManager;

        backBtn.onClick.AddListener(ClinkBackButton);
        statusUI.CloseUI();
        invenUI.CloseUI();
    }

    private void ClinkBackButton()
    {
        if (statusUI.gameObject.activeSelf)
        {
            statusUI.CloseUI();
        }
        else if(invenUI.gameObject.activeSelf)
        {
            invenUI.CloseUI();
        }
        menuUI.gameObject.SetActive(true);
        backBtn.gameObject.SetActive(false);
    }
}
