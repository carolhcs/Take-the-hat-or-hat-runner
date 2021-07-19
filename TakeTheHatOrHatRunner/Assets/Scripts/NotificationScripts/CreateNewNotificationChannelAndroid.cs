using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewNotificationChannelAndroid", menuName = "TakeTheHat/CreateNewNotificationChannelAndroid", order = 1)]
public class CreateNewNotificationChannelAndroid : ScriptableObject
{
    public string channelId;
    public string channelName;
    public string channelDescription;
}
