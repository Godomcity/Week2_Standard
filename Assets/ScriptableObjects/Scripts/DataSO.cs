using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultDataSO", menuName = "QusetDataSO/Quest/Default", order = 0)]

public class DataSO : ScriptableObject
{
    [Header("Quset Info")]

    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<DataSO> QuestPrerequisites;
}