using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
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
        foreach (var quest in quests)
        {
            if (quest is MonsterQuestDataSO monsterdata)
            {
                Debug.Log($"Quest {quest.QuestPrerequisites[0]} - {quest.QuestName} (최소레벨{quest.QuestRequiredLevel})" +
                $"\n{monsterdata.MonsterName}를 {monsterdata.Monster}마리 소탕");
            }
            
            if (quest is EncounterQuestDataSO encountdata)
            {
                Debug.Log($"Quest {quest.QuestPrerequisites[0]} - {quest.QuestName} (최소레벨{quest.QuestRequiredLevel})" +
                $"\n{encountdata.npcName}과 대화하기");
            }
        }
    }
}
