using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewNotificationModelAndroid", menuName = "TakeTheHat/CreateNewNotificationModelAndroid", order = 1)]
public class CreateNewNotificationModelAndroid : ScriptableObject
{
   [Header("NotificationManager Info:")]
    public string notificationTitle;
    public string notificationText;

    [Header("Fire Time: ")]
    public int seconds = 0;
    public int minutes = 0;
    public int hours = 0;
    public int days = 0;

    [Header("Repeat Interval: ")]
    public int second = 0;
    public int minute = 0;
    public int hour = 0;
    public int day = 0;


    private DateTime dateTime;
    private TimeSpan timeSpan;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public DateTime GetDateTime()
    {
        if(days > 0) dateTime = DateTime.Now.AddDays(days);
        else if(hours > 0) dateTime = DateTime.Now.AddHours(hours);
        else if (minutes > 0) dateTime = DateTime.Now.AddMinutes(minutes);
        else if (seconds > 0) dateTime = DateTime.Now.AddSeconds(seconds);

        return dateTime;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public TimeSpan GetTimeSpan()
    {
        if (day > 0) timeSpan = new TimeSpan(day, hour, minute, second);
        else if (hour > 0) timeSpan = new TimeSpan(0, hour, minute, second);
        else if (minute > 0) timeSpan = new TimeSpan(0, 0, minute, second);
        else if (second > 0) timeSpan = new TimeSpan(0, 0, 0, second);

        return timeSpan;
    }
}
