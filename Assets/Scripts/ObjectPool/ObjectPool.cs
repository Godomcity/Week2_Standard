using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private List<GameObject> pool = new List<GameObject>();
    private Dictionary<string, Queue<GameObject>> poolDictionaty;
    public int poolSize = 300;

    void Start()
    {
        poolDictionaty = new Dictionary<string, Queue<GameObject>>();

        foreach (var poolObj in pool)
        {
            Queue<GameObject> queue = new Queue<GameObject>();
            for (int i = 0; i < poolSize; i++)
            {
                GameObject go = Instantiate(prefab);
                go.SetActive(false);
                queue.Enqueue(go);
            }
            poolDictionaty.Add(poolObj.name, queue);
        }
    }

    public GameObject Get(string name)
    {
        if (!poolDictionaty.ContainsKey(name))
        {
            return null;
        }

        GameObject go = poolDictionaty[name].Dequeue();
        poolDictionaty[name].Enqueue(go);

        go.SetActive(true);
        return go;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false);
    }
}
