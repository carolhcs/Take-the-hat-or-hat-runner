using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class EnvironmentSpawner : MonoBehaviour
{

    //TODO: Adicionar chance de gerar uma trap a mais quando gerar uma com colisão
    //(espaço entre traps 4, pode ser 2 ou 3 o espaço para a nova)
    // Chance aumenta conforme mais pontos

    public string spawnerId = "Id";

    public GameObject[] objectSpawnerPrefab;
    public TrapsManager trapsManager;

    //public SpawnersChance[] SelectChance = new SpawnersChance[10]; // TODO: 

    public void SpawnObjectByChance(string kind)
    {
        //TODO: ...
        int index = 0;

        if (kind.Equals("Trap")) 
        { 
            InstantiateObject(trapsManager.ChooseTrap(), -1.5f);
            // TODO: pegar a pontuação atual e contar a chance de gerar mais um trap, usar o random para gerar ou não

        }
        else if (kind.Equals("Floor")) InstantiateObject(objectSpawnerPrefab[index]);

    }

    public void SpawnObjectByIndex(int index, string kind)
    {
        if (kind.Equals("Trap")) InstantiateObject(trapsManager.ChooseTrap(), -1.5f);
        else if (kind.Equals("Floor")) InstantiateObject(objectSpawnerPrefab[index]);
    }

    private void InstantiateObject(GameObject gameObjectPrefab)
    {
        GameObject newGameObject = Instantiate(gameObjectPrefab, 
            new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 
            this.gameObject.transform.position.z), Quaternion.identity);

        newGameObject.transform.SetParent(this.gameObject.transform);
    }

    private void InstantiateObject(GameObject gameObjectPrefab, float yPosition)
    {
        GameObject newGameObject = Instantiate(gameObjectPrefab,
            new Vector3(this.gameObject.transform.position.x, yPosition,
            this.gameObject.transform.position.z), Quaternion.identity);

        newGameObject.transform.SetParent(this.gameObject.transform);
    }

    private void InstantiateSecondObject(GameObject gameObjectPrefab, float distance)
    {
        float newPositionX = this.gameObject.transform.position.x + distance;
        GameObject newGameObject = Instantiate(gameObjectPrefab,
            new Vector3(newPositionX, this.gameObject.transform.position.y,
            this.gameObject.transform.position.z), Quaternion.identity);

        newGameObject.transform.SetParent(this.gameObject.transform);
    }

    private void InstantiateSecondObject(GameObject gameObjectPrefab, float distance, float yPosition)
    {
        float newPositionX = this.gameObject.transform.position.x + distance;
        GameObject newGameObject = Instantiate(gameObjectPrefab,
            new Vector3(newPositionX, yPosition,
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
