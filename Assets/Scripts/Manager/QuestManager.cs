using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public DataSO[] quests;
    public MonsterQuestDataSO[] monsters;
    public EncounterQuestDataSO[] encounters;

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
        //Debug.Log($"Quest 1 - {quests[0].QuestName} (�ּ� ���� {quests[0].QuestRequiredLevel})");
        Debug.Log($"Quest 1 - {monsters[0].QuestName} (�ּ� ���� {monsters[0].QuestRequiredLevel})" +
            $" {monsters[0].MonsterName}�� {monsters[0].Monster}���� ����");
        //Debug.Log($"Quest 2 - {quests[1].QuestName} (�ּ� ���� {quests[1].QuestRequiredLevel})");
        Debug.Log($"Quest 2 - {encounters[0].QuestName} (�ּ� ���� {encounters[0].QuestRequiredLevel})" +
            $" {encounters[0].npcName}�� ��ȭ�ϱ�");
    }
}
