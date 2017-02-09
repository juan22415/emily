using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text playerScore;
    private PlayerData data;

    public static ScoreManager Instance
    {
        get; private set;
    }

    public int Score
    {
        get
        {
            return data.score;
        }

        set
        {
            data.score = value;
        }
    }

    private void Awake()
    {
        if (Instance != null)
            Destroy(this);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {

        playerScore.text = "Score:" + Score;
    }
	
	// Update is called once per frame
	void Update () {
        playerScore.text = "Score:" + Score;
    }
}
