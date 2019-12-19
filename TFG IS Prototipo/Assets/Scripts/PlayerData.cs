using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData {

    public string playerName;
    public int calories;
    public int carbohydrates;
    public int proteins;
    public int fats;
    public float[] position;

    public bool missionCompleted;
    
    public PlayerData (Player player)
    {
        playerName = player.playerName;
        calories = player.calories;
        carbohydrates = player.carbohydrates;
        proteins = player.proteins;
        fats = player.fats;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        missionCompleted = player.missionCompleted;

    }
}
