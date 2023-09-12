using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{

    public int[] enemyStats = new int[6];
    int enemies = 0;
    public int enemiesToSpawn = 10;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(enemyStats[1]);

        while(enemies < enemiesToSpawn)
        {
            Debug.Log("Enemies Spawned");
            enemies++;
        }

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Debug.Log("Enemies Spawned");
        }
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
