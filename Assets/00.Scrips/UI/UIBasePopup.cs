using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIBasePopup : MonoBehaviour
{
    public virtual void OpenUI()
    {
        gameObject.SetActive(true);
    }

    public virtual void CloseUI()
    {
        gameObject.SetActive(false);
    }
}
