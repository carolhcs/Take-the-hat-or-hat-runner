using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreateNewEnvironment", menuName = "TakeTheHat/CreateNewEnvironment", order = 1)]
public class CreateEnvironment : ScriptableObject
{
    public string environmentId = "StartEnv";
    public string environmentName = "New Environment";
    public GameObject[] environmentTrapsPrefabs;

}
