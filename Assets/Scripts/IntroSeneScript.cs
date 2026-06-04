using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSeneScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Select_Player");
    }
    public void SkinSelection()
    {
        SceneManager.LoadScene("Skin_Selection");
    }
}