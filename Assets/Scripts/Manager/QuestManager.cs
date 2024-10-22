using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public static QuestManager Instance 
    { 
        get 
        {
            if (instance == null)
            {
                FindObjectOfType<QuestManager>();
                new GameObject().AddComponent<QuestManager>();
            }
            return instance; 
        }
        set { instance = value; }
    }
}
