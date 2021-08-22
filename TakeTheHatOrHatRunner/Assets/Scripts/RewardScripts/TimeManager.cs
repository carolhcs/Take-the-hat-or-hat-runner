using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

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
    private float timer = 10f;
    private int upSpeedTimer = 0;
    private float velocityTimer = 10f;
    private float rewardTimer = DataManager.TIMER_REWARD;
    private enum SPEED_TIMER_MARKER { SPEED_TIME_01, SPEED_TIME_02, SPEED_TIME_03 };
    private SPEED_TIMER_MARKER speed_timer_mark;

    public UnityEvent rewardTime;
    public UnityEvent speedTime;

    void Start()
    {
        Seconds = 0;
        Minuts = 0;
        Hours = 0;
        speed_timer_mark = SPEED_TIMER_MARKER.SPEED_TIME_01;
        EnvironmentStatus.Velocity = DataManager.INITIAL_SPEED;
    }

    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name.Equals("GameScene"))
        {
            TimerCount();
            VelocityTimers();
            RewardTimers();
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

    /// <summary>
    /// Controle de Velocidade
    /// </summary>
    private void VelocityTimers()
    {
        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {
            if(EnvironmentStatus.Velocity < 10f)
            {
                speedTime.Invoke();
                if ((speed_timer_mark == SPEED_TIMER_MARKER.SPEED_TIME_01) && (upSpeedTimer < 5))
                {
                    timer = DataManager.SPEED_TIMER_1;
                    EnvironmentStatus.Velocity += DataManager.SPEED_INCREASE_1;
                }
                else if ((speed_timer_mark == SPEED_TIMER_MARKER.SPEED_TIME_02) && (upSpeedTimer < 15))
                {
                    timer = DataManager.SPEED_TIMER_2;
                    EnvironmentStatus.Velocity += DataManager.SPEED_INCREASE_2;
                }
                else if ((speed_timer_mark == SPEED_TIMER_MARKER.SPEED_TIME_03) && (upSpeedTimer >= 15))
                {
                    timer = DataManager.SPEED_TIMER_3;
                    EnvironmentStatus.Velocity += DataManager.SPEED_INCREASE_3;
                }
                upSpeedTimer++;
            }
        }
    }

    private void RewardTimers()
    {
        rewardTimer -= Time.fixedDeltaTime;
        if (rewardTimer <= 0)
        {
            rewardTime.Invoke();
            rewardTimer = DataManager.TIMER_REWARD;
        }
    }
}
