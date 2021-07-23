using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class EnvironmentSpawner : MonoBehaviour
{

    public string spawnerId = "Id";

    public GameObject[] objectSpawnerPrefab;

    //public SpawnersChance[] SelectChance = new SpawnersChance[10]; // TODO: 

    public void SpawnObjectByChance()
    {
        //TODO: ...
        int index = 0;

        InstantiateObject(objectSpawnerPrefab[index]);
    }

    public void SpawnObjectByIndex(int index)
    {
        InstantiateObject(objectSpawnerPrefab[index]);
    }

    private void InstantiateObject(GameObject gameObjectPrefab)
    {
        GameObject newGameObject = Instantiate(gameObjectPrefab, 
            new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 
            this.gameObject.transform.position.z), Quaternion.identity);

        newGameObject.transform.SetParent(this.gameObject.transform);
    }
    
}

/// <summary>
/// 
/// </summary>
public class SpawnersChance
{
    public int indexMin;
    public int indexMax;
    public float chance;

    public SpawnersChance(int indexMin, int indexMax, float chance)
    {
        this.indexMin = indexMin;
        this.indexMax = indexMax;
        this.chance = chance;
    }
}
