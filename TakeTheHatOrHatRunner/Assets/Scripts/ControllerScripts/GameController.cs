using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject endScreen;
    public Button newLifeVideo;

    void Awake()
    {
        GameStatus.InitiateGameStatus(0, 0, true, false, false);
    }

    void Start()
    {
        
    }

    // GamePlay Functions

    public void PlayGame()
    {

    }

    public void FirstGameEnd()
    {

    }

    public void SecondGameEnd()
    {

    }

    public void PauseGame(bool pause)
    {
        pause = !pause;
        GameStatus.IsPause = pause;
        if (pause) Time.timeScale = 0;
        else Time.timeScale = 1;

    }

    private IEnumerator WaitForSecondsCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
