using System.Collections;
using System.Collections.Generic;
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
    }

    private void InitializeManagers()
    {
        UIManager = FindObjectOfType<UIManager>();

        UIManager.Init(this);
    }
}
