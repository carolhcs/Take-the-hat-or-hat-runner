using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //public GameObject objGameController;



    public GameController gameController;
    public RewardManager rewardManager;
    public LocalSave save;

    public static GameManager Instance;

    void Awake()
    {
        // Instance
        if (Instance != null)
        {
            GameObject.Destroy(Instance);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        // Inicializar dados
        if (SceneManager.GetActiveScene().name.Equals("MenuScene"))
        {
            DataManager.InitializeData();
            save.LoadGameData();
        }

    }

    void Start()
    {
        SetupScenne(SceneManager.GetActiveScene().name);
    }

    
    void Update()
    {
        
    }

    private void SetupScenne(string scenneName)
    {
        switch (scenneName)
        {
            case "GameScene":
                gameController.PauseGame(GameStatus.IsPause);
                break;
            case "":
                //...
                break;
        }
    }



}
