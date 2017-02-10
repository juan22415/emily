using System;
using System.Collections.Generic;

[Serializable]
public class LeaderboardData
{
    public List<PlayerData> players;

    public LeaderboardData()
    {
        players = new List<PlayerData>();
    }
}
