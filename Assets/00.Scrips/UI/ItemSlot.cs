using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{  
    [SerializeField] Image itemImage;
    [SerializeField] Image equipImage;
    [SerializeField] Button selectBtn;
    public int index;
    public ItemData curItem;

    private void Start()
    {
        selectBtn.onClick.AddListener(SecletSlot);
    }

    public void SetSlot(ItemData item)
    {
        if (curItem != null) return;

        curItem = item;
        itemImage.enabled = true;
        itemImage.sprite = curItem.icon;

        equipImage.enabled = curItem.isEquip;
    }

    public void ClerSlot()
    {
        curItem = null;
        itemImage.sprite = null;
        itemImage.enabled = false;
        equipImage.enabled = false;
    }

    public void SecletSlot()
    {
        GameManager.Instance.UIManager.invenUI.SelctSlot(index);
    }
}
