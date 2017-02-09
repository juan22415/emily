using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillPlayerData : MonoBehaviour
{
    public Leaderboard myLeaderboard;
    public string currentPlayer;

    public void FillData(string name)
    {
        currentPlayer = name;
    }

    public void CreatePlayer()
    {
        myLeaderboard.CreatePlayerData(currentPlayer);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ToJson();
        }
    }

    public void ToJson()
    {
        string json = JsonUtility.ToJson(myLeaderboard);
        Debug.Log(json);
    }
}
