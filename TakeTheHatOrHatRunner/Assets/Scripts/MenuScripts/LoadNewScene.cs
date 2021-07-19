using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public void LoadScene(string scenneName)
    {
        SceneManager.LoadScene(scenneName);
    }

    public void LoadSceneAdditive(string scenneName)
    {
        SceneManager.LoadScene(scenneName, LoadSceneMode.Additive);
    }
}
