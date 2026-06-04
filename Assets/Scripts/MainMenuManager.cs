using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject[] players;
    public int[] playersPrices;

    public Text playerPrice, totalcashtxt;

    public GameObject buybtn;

    int Totalcash = 300;

    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        players[i].SetActive(true);
        totalcashtxt.text = "BALANCE:"+Totalcash.ToString();
    }

    public void StartGame()
    {
        // This command stops the current scene and loads the one named "Level1"
        SceneManager.LoadScene("Main_Scene");
    }


    public void rightBtnClicked(){
        players[i].SetActive(false);
        i++;
        if(i==4)
        i=0;
        players[i].SetActive(true);
        playerPrice.text = "Price: " + playersPrices[i];
    }
    public void leftBtnClicked(){
        players[i].SetActive(false);
        i--;
        if(i==-1)
        i=3;
        players[i].SetActive(true);
        playerPrice.text = "Price: " + playersPrices[i];
    }


    public void buyBtnClicked()
    {
        if (Totalcash >= playersPrices[i])
        {
            Totalcash = Totalcash - playersPrices[i];
            totalcashtxt.text ="BALANCE:" + Totalcash.ToString();

            
            buybtn.SetActive(false);
        }
        else
        {
            print("you do not have enough cash");
        }
    }


}
