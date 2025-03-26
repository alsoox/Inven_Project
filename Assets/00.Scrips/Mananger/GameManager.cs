using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return instance;
        }
    }
    public UIManager UIManager { get; private set; }
    private Player player;
    public Player Player { get => player; set => player = value; }

    private Inventory inven;
    public Inventory Inven => inven;
 
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        InitializeManagers();

        player = new Player(30, 20, 100, 5, 3, 20, "백수", "강순종", "오늘도 열심히 코딩중입니다.", 10000);
        inven = new Inventory(36);
        SetItem();

        //Debug.Log(inven.itemDatas.Count);
    }

    private void InitializeManagers()
    {
        UIManager = FindObjectOfType<UIManager>();

        UIManager.Init(this);
    }

    void SetItem()
    {
        List<ItemData> allItems = new List<ItemData>(Resources.LoadAll<ItemData>("ScripableObject/SO"));

        for (int i = 0; i < allItems.Count; i++)
        {
            inven.GetItem(allItems[i]);
        }
    }
}
