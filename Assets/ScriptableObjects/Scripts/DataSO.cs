using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultDataSO", menuName = "QusetDataSO/Quest/Default", order = 0)]

public class DataSO : ScriptableObject
{
    [Header("Quset Info")]

    string QuserName;
    int QuestRequiredLevel;
    int QuestNPC;
    List<int> QuestPrerequisites;
}