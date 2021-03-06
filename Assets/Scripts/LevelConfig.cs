using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LevelConfig")]
public class LevelConfig : ScriptableObject
{
    [Header("General")]
    public float healthDrainSpeed = 10f;

    [Header("Human")]
    // vision
    public float alertRiseUpSpeed = 10f;
    public float alertRiseDownSpeed = 10f;

    [Header("Pries")]
    public float priestPrayerDrainSpeed = 2f;

    [Header("Spawn Config")]
    public int humanCount = 10;
    public int priestCount = 10;
    public int innocentCount = 10;

    public float firstSpawnDelayMin = 3f;
    public float firstSpawnDelayMax = 5f;
    public float spawnIntervalMin = 5f;
    public float spawnIntervalMax = 10f;
    public int spawnGroupMin = 2;
    public int spawnGroupMax = 2;
    public float spawnGroupIntervalMin = 2f;
    public float spawnGroupIntervalMax = 2f;
    public int spawnInGroupProbability = 40;

}
