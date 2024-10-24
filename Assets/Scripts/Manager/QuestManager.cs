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
                Debug.Log($"Quest {quest.QuestPrerequisites[0]} - {quest.QuestName} (�ּҷ���{quest.QuestRequiredLevel})" +
                $"\n{monsterdata.MonsterName}�� {monsterdata.Monster}���� ����");
            }
            
            if (quest is EncounterQuestDataSO encountdata)
            {
                Debug.Log($"Quest {quest.QuestPrerequisites[0]} - {quest.QuestName} (�ּҷ���{quest.QuestRequiredLevel})" +
                $"\n{encountdata.npcName}�� ��ȭ�ϱ�");
            }
        }
    }
}
