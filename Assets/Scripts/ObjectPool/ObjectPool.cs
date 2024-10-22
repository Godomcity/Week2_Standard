using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSIze = 300;

    void Start()
    {
        for (int i = 0; i < poolSIze; i++)
        {
            GameObject go = Instantiate(prefab);
            go.SetActive(false);
            pool.Add(go);
        }
    }

    public GameObject Get()
    {
        GameObject obj = null;
        foreach (GameObject go in pool)
        {
            obj = go;
            obj.SetActive(true);
        }
        return obj;
    }

    public void Release(GameObject obj)
    {

    }
}
