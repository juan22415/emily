using System;
using System.Collections.Generic;
using UnityEngine;


public class Leaderboard : MonoBehaviour
{
    public string leaderboardKey;
    public LeaderboardData data;

    private void Awake()
    {
        data = LoadLeaderboard();
    }

    private void Start()
    {
        data.players.Add(new PlayerData ("Manuela", ScoreManager.Instance.Score));
    }

    private LeaderboardData LoadLeaderboard()
    {
        string jsonLeaderboard = PlayerPrefs.GetString(leaderboardKey, null);
        if (string.IsNullOrEmpty(jsonLeaderboard))
            return GenerateNewLeaderboard();
        else
            return ParseLeaderboard(jsonLeaderboard);
    }

    private LeaderboardData GenerateNewLeaderboard()
    {
        return new LeaderboardData();
    }

    private LeaderboardData ParseLeaderboard(string jsonLeaderboard)
    {
        return JsonUtility.FromJson<LeaderboardData>(jsonLeaderboard);
    }

    private void SaveLeaderboard()
    {
        string jsonLeaderboard = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(leaderboardKey, jsonLeaderboard);
    }
}
