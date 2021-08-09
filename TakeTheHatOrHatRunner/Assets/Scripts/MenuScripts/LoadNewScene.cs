using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public LocalSave save;

    public void LoadScene(string scenneName)
    {
        save.SaveGameData();
        SceneManager.LoadScene(scenneName);
    }

    public void LoadSceneAdditive(string scenneName)
    {
        SceneManager.LoadScene(scenneName, LoadSceneMode.Additive);
    }
}
