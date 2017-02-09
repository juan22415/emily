using System;
using System.Collections.Generic;
using UnityEngine;


public class Leaderboard : MonoBehaviour
{
    public List<PlayerData> leaderboard;

    public void CreatePlayerData(string name)
    {
        leaderboard.Add(new PlayerData(name));
    }
}
