using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class UIPopupPool
{
    private readonly Dictionary<string, UIBasePopup> popupPool;

    public UIPopupPool()
    {
        popupPool = new Dictionary<string, UIBasePopup>();
    }

    public void ShowPopup(string popupName)
    {

    }
}
