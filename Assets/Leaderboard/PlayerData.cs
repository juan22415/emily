using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData 
{
    public string playerName;
    public int score;
    ScoreManager scriptscore;

    public PlayerData(string name)
    {
        playerName = name;
        Debug.Log(score);
    }

}
