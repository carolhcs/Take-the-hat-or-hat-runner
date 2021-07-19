using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif

/// <summary>
/// 
/// </summary>
public static class NotificationManager
{
#if (UNITY_ANDROID)

    /// <summary>
    /// 
    /// </summary>
    public static void CreateNewNotifChannelAndroid(string channelId, string channelName, string channelDescription)
    {
        var channel = new AndroidNotificationChannel()
        {
            Id = channelId,
            Name = channelName,
            Importance = Importance.High,
            Description = channelDescription,
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }
       
    /// <summary>
    /// 
    /// </summary>
    public static AndroidNotification CreateNewNotificationAndroid(string notificationTitle, string notificationText, DateTime dateTime)
    {
        var notification = new AndroidNotification();
        notification.Title = notificationTitle;
        notification.Text = notificationText;
        notification.FireTime = dateTime; //DateTime.Now.AddSeconds(10); //AddMinutes(1);

        return notification;
    }

    /// <summary>
    /// 
    /// </summary>
    public static AndroidNotification CreateNewNotificationAndroid(string notificationTitle, string notificationText, DateTime dateTime, TimeSpan timeSpan)
    {
        var notification = new AndroidNotification();
        notification.Title = notificationTitle;
        notification.Text = notificationText;
        notification.FireTime = dateTime; //DateTime.Now.AddSeconds(10); //AddMinutes(1);
        notification.RepeatInterval = timeSpan;
        return notification;
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SendNewNotificationAndroid(AndroidNotification notification, string channelId)
    {
        AndroidNotificationCenter.SendNotification(notification, channelId);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void CancelAllNotificationsAndroid()
    {
        AndroidNotificationCenter.CancelAllDisplayedNotifications();
        AndroidNotificationCenter.CancelAllScheduledNotifications();
        AndroidNotificationCenter.CancelAllNotifications();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool GetNotificationStatusScheduled(int id)
    {
        var notificationStatus = AndroidNotificationCenter.CheckScheduledNotificationStatus(id);

        if (notificationStatus == NotificationStatus.Scheduled)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

#endif
}
