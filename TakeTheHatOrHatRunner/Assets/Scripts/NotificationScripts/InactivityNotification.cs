using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactivityNotification : MonoBehaviour
{
    public CreateNewNotificationChannelAndroid[] androidNotificationChannels;

    public CreateNewNotificationModelAndroid[] androidNotifications;


#if (UNITY_ANDROID)
    private void Start()
    {
        NotificationManager.CancelAllNotificationsAndroid();
        RegistryNewNotifications(androidNotificationChannels[0], androidNotifications[0]); //Apareceu uma vez quando abri o app

    }

    private void Update()
    {
        //FindObjectOfType<DebugGame>().SetOnDebugText("Start: "+ NotificationManager.GetNotificationStatusScheduled(0), 1);
    }

    private void OnApplicationQuit()
    {
        RegistryNewNotifications(androidNotificationChannels[3], androidNotifications[3]); // Não apareceu nenhuma notificação após o aplicativo ser fechado
    }

    private void OnApplicationPause(bool pause)
    {
        RegistryNewNotifications(androidNotificationChannels[2], androidNotifications[2]); // Apareceu uma vez quando o aplicativo estava aberto porem em segundo plano
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="focused"></param>
    private void OnApplicationFocus(bool focused)
    {
        if (!focused)
        {
            RegistryNewNotifications(androidNotificationChannels[1], androidNotifications[1]); // Apareceu repetidas vezes enquanto o jogo estava aberto?? // Apareceu uam vez quando o aplicativo estava aberto porem em segundo plano??
        }

        if (focused)
        {
            RegistryNewNotifications(androidNotificationChannels[4], androidNotifications[4]); // Apareceu uam vez quando o aplicativo estava aberto porem em segundo plano // Apareceu repetidas vezes enquanto o jogo estava aberto?? 
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void RegistryNewNotifications(CreateNewNotificationChannelAndroid androidNotificationChannel, CreateNewNotificationModelAndroid androidNotification)
    {
        NotificationManager.CreateNewNotifChannelAndroid(androidNotificationChannel.channelId, androidNotificationChannel.channelName, androidNotificationChannel.channelDescription);
        NotificationManager.SendNewNotificationAndroid(
            NotificationManager.CreateNewNotificationAndroid(androidNotification.notificationTitle, androidNotification.notificationText, androidNotification.GetDateTime()), 
            androidNotificationChannel.channelId
        );
    }

#endif
}
