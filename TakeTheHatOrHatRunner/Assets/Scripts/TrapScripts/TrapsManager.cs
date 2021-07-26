using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class TrapsManager : MonoBehaviour
{
    //...
    public CreateEnvironment[] environmentsConfigurations;

    // Pegar ambiente atual
    // Escolher trap dentre listas de traps possiveis do ambiente atual
    // função que retorna game object escolhido, e tbm sua altura Y
    // Esse será pego no environment spowner que irá instanciar o objeto

    public GameObject ChooseTrap()
    {
        return environmentsConfigurations[0].environmentTrapsPrefabs[0];

    }
}
