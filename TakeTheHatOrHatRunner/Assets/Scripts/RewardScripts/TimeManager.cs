using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controlador e contador de tempo
/// Referencia de tempo para o jogo
/// </summary>
public class TimeManager : MonoBehaviour
{
    public float Seconds { get; set; }
    public float Minuts { get; set; }
    public float Hours { get; set; }
    private float time = 0f;

    void Start()
    {
        Seconds = 0;
        Minuts = 0;
        Hours = 0;
    }

    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name.Equals("GameScene"))
        {
            TimerCount();
        }
    }

    private void TimerCount()
    {
        time += Time.fixedDeltaTime;
        Seconds = time;
        if (Seconds >= DataManager.TIMER)
        {
            Minuts++;
            Seconds = 0;
        }

        if (Minuts >= DataManager.TIMER)
        {
            Hours++;
            Minuts = 0;
        }
        
    }

    private void VelocityTimers()
    {
        float timer = 10;
        // velocidade
        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {

        }

    }
}
