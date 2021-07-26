using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class ObjectDestroyer : MonoBehaviour
{
    [Header("Tags:")]
    public string[] tagsToDestroy;
    [Header("Spawner:")]
    public EnvironmentSpawner objectSpawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SearchTag(collision.gameObject.tag)) DestroyObject(collision.gameObject, collision.gameObject.tag);
    }

    private bool SearchTag(string tag)
    {
        for(int i = 0; i < tagsToDestroy.Length; i++)
        {
            if (tag.Equals(tagsToDestroy[i])) return true;
        }
        return false;
    }

    private void DestroyObject(GameObject gameObject, string tag)
    {
        Destroy(gameObject);
        objectSpawner.SpawnObjectByChance(tag);
    }
}
