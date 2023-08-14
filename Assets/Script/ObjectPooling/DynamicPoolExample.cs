using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Modulized.Utilities.ObjectPooling;

public class DynamicPoolExample : MonoBehaviour
{
    public Transform obj;
    public Transform prefab;
    public DynamicPool<Transform> Pool;
    private void Start()
    {

        Pool = new DynamicPool<Transform>(prefab, transform.position, 10,
        obj, 5, null);

        // Pool.CreateObjects(15);

        foreach (var item in Pool.GetActiveObjects())
        {
            Debug.Log(item + "  ", gameObject);
            
        }

    }
    private void GetAllObject()
    {

        var temp = Pool.GetAllObjects();
    }




}