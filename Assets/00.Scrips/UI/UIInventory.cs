using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : UIBasePopup
{
    [Header("Quantity")]
    [SerializeField] TextMeshProUGUI qtyTxt;

    [Header("SlotInfo")]
    [SerializeField] Transform slotsObj;
    [SerializeField] GameObject slotPrefap;

    [Header("Btton")]
    [SerializeField] Button equipBtn;
    [SerializeField] Button unequipBtn;
    [SerializeField] Button throwBtn;

    public ItemData selectItem;
    public ItemSlot selectSlot;
    int slotCount;
    ItemSlot[] slots;

    public Action equip;

    Inventory inven;
    Player player;
    private void Start()
    {
        player = GameManager.Instance.Player;
        inven = GameManager.Instance.Inven;

        slotCount = inven.maxQty;
        slots = new ItemSlot[slotCount];
        for (int i = 0; i < slots.Length; i++)
        {
            Instantiate(slotPrefap, slotsObj);
            slots[i] = slotsObj.GetChild(i).GetComponent<ItemSlot>();
            slots[i].index = i;
        }

        equipBtn.onClick.AddListener(OnEquipButton);
        unequipBtn.onClick.AddListener(OnUnEquipButton);
        throwBtn.onClick.AddListener(OnThrowButton);

        UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
    }

    void UpdateUI()
    {
        qtyTxt.text = $"{inven.curQty} / {inven.maxQty}";

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].ClerSlot();   
        }

        int index = 0;

        foreach (var pair in inven.itemDatas)
        {
            ItemData item = pair.Key;

            slots[index].SetSlot(item);
            index++;
        }
    }

    public void SelctSlot(int index)
    {
        if (slots[index].curItem == null) return;

        selectItem = slots[index].curItem;
        selectSlot = slots[index];

        SetEquipButton();
    }

    public void OnEquipButton()
    {
        if (selectItem == null) return;

        switch(selectItem.valuetype)
        {
            case ValueType.Power:
                player.ChangePower(selectItem.value);
                break;
            case ValueType.Armor:
                player.ChangeArmor(selectItem.value);
                break;
            case ValueType.Health:
                player.ChangeHealth(selectItem.value);
                break;
            case ValueType.Critical:
                player.ChangeCritical(selectItem.value);
                break;
        }
        equip?.Invoke();
        selectItem.isEquip = true;
        SetEquipButton();
        UpdateUI();
    }

    public void OnUnEquipButton()
    {
        if (selectItem == null) return;

        switch (selectItem.valuetype)
        {
            case ValueType.Power:
                player.ChangePower(-selectItem.value);
                break;
            case ValueType.Armor:
                player.ChangeArmor(-selectItem.value);
                break;
            case ValueType.Health:
                player.ChangeHealth(-selectItem.value);
                break;
            case ValueType.Critical:
                player.ChangeCritical(-selectItem.value);
                break;
        }
        equip?.Invoke();
        selectItem.isEquip = false;
        SetEquipButton();
        UpdateUI();
    }

    public void OnThrowButton()
    {
        inven.TrowItem(selectItem);

        UpdateUI();

        Debug.Log(GameManager.Instance.Inven.itemDatas.Count);
    }

    private void SetEquipButton()
    {
        if (selectItem.isEquip)
        {
            equipBtn.gameObject.SetActive(false);
            unequipBtn.gameObject.SetActive(true);
        }
        else
        {
            equipBtn.gameObject.SetActive(true);
            unequipBtn.gameObject.SetActive(false);
        }
    }
}
