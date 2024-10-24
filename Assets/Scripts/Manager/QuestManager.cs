using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public DataSO[] quests; 

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

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Debug.Log($"Quest 1 - {quests[0].QuestName} (최소 레벨 {quests[0].QuestRequiredLevel})");
        Debug.Log($"Quest 2 - {quests[1].QuestName} (최소 레벨 {quests[1].QuestRequiredLevel})");
    }
}
