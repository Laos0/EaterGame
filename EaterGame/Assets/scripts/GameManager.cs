using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject player;
    public Spawner spawner;
    private bool isGameOver;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        score = 0; // score that will be used to display the score 
        InvokeRepeating("startSpawner", 2, 5);

    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            // end the game, pause etc.
        }
    }

    void startSpawner()
    {
        spawner.spawn();
    }
}
