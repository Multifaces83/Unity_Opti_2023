using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesPool : Pool
{
    [SerializeField] Factory ennemiesFactory;
    private List<Transform> ennemiesReferences;

    private void Awake()
    {
        ennemiesReferences = new List<Transform>();
    }

    public override Transform Get(Vector3 position)
    {
        for (int i = 0; i < ennemiesReferences.Count; i++)
        {
            if (!ennemiesReferences[i].gameObject.activeInHierarchy)
            {
                ennemiesReferences[i].gameObject.SetActive(true);
                ennemiesReferences[i].position = position;
                return ennemiesReferences[i];
            }
        }
        Transform ennemy = ennemiesFactory.Generate(position);
        ennemiesReferences.Add(ennemy);
        return ennemy;
    }

    public override void Release(Transform element)
    {
        element.gameObject.SetActive(false);
    }
}
