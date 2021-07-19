using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// On Hat Prefabs
/// Hat description info
/// </summary>
public class Hat : MonoBehaviour
{
    [Header("Hat info:")]
    [Tooltip("Hat Name")] public int hatId;
    [Tooltip("Hat Name")] public string hatName;
    [Tooltip("Hat Description or History")] public string hatDescription;
    [Tooltip("Hat Value in Store")] public int hatValue;
    [Tooltip("Player Buy This Hat?")] public bool playerHasThis;
}
