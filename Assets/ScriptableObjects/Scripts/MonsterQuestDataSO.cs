using UnityEngine;

[CreateAssetMenu(fileName = "DefaultDataSO", menuName = "QusetDataSO/Quest/MonsterQuest", order = 0)]

public class MonsterQuestDataSO : DataSO
{
    [Header("Monster Info")]

    public string MonsterName;
    public int MonsterLevel;
    public int Monster;
}