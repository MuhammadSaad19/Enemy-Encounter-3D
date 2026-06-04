using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Enemies;
    public GameObject[] enemySpawnPOS;
    int i = 0;
    int totalcash = 0;
    public Text cash;

    
    // Start is called before the first frame update
    void Start()
    {
        // Load the saved cash. If no save exists, start at 0.
        totalcash = PlayerPrefs.GetInt("MyCash", 0);
        cash.text = "Coins: " + totalcash;
        
        InvokeRepeating("spawnEnemies", 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnEnemies()
    {
        i = Random.Range(0, 3);
        Instantiate(Enemies, enemySpawnPOS[i].transform.position, enemySpawnPOS[i].transform.rotation);
        // i++;
        // if(i == 3)
        // i=0;

    }
    public void scoreCounter()
    {
        totalcash = totalcash + 50;
        cash.text = "Coins: " + totalcash;
        PlayerPrefs.SetInt("MyCash", totalcash);
    }
}
