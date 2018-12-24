using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManager : Singleton<GamesManager>
{
    public GameObject player;
    public Spawner spawner;
    private bool isGameOver;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        score = 0; // score that will be used to display the score 
        InvokeRepeating("startSpawner", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void startSpawner()
    {
        spawner.spawn();
    }

    void onCollisionEnter(Collision col)
    {
      
    }

    public void addScore(int value)
    {
        score += value;
        if (score <= 0)
        {
            score = 0;
        }
       
    }

    public int getScore()
    {
        return score;
    }
}
