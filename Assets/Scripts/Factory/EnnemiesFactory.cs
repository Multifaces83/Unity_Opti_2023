using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesFactory : Factory
{
    [SerializeField] private GameObject[] ennemiesPrefabs;

    public override Transform Generate(Vector3 position)
    {
        int randomIndex = Random.Range(0, ennemiesPrefabs.Length);
        GameObject ennemy = Instantiate(ennemiesPrefabs[randomIndex], position, Quaternion.identity);
        return ennemy.transform;
    }
}
