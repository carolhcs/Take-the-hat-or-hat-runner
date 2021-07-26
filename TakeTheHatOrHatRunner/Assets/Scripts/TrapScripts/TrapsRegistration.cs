using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsRegistration : MonoBehaviour
{
    public string trapId = "Id";
    public enum KIND_TRAP { STOPED, MOVEMENT };
    public KIND_TRAP kindTrap;
    public float movementSpeed = 0f;
    public float height = 0f;
    // ... Var de area que essa tarp pode aparecer
}
