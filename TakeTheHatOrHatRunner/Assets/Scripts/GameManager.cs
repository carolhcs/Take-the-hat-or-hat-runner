using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //public GameObject objGameController;



    public GameController gameController;
    public static GameManager Instance;

    void Awake()
    {
        if (Instance != null)
        {
            GameObject.Destroy(Instance);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
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
                gameController.PauseGame(gameController.gameStatus.IsPause);
                break;
            case "":
                //...
                break;
        }
    }


}
