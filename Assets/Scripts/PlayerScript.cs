using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject sceneLight;
    public GameObject MyPlayer;
    public float moveSpeed = 10f; // Ensure this is not 0 in Inspector!
    bool isForward,isReverse,isLeft,isRight;
    public Slider healthBar;
    private float currentHealth = 1f; // 1.0 is 100%
    public GameObject gameOverPanel; // Drag your Panel here


    // Start is called before the first frame update
    void Start()
    {
       //lightOn();
       isForward = false;
       isReverse = false;
       isLeft = false;
       isRight = false;

        healthBar.value = currentHealth;


    }

    // Update is called once per frame
    void Update(){
       // MyPlayer.transform.position = new Vector3(MyPlayer.transform.position.x + Input.GetAxis("Horizontal"), MyPlayer.transform.position.y, MyPlayer.transform.position.z + Input.GetAxis("Vertical"));


       
            if (isForward)
            {
            Debug.Log("Character should be moving now!");
            // Move the object forward
            MyPlayer.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
            if (isReverse)
            {
                MyPlayer.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }
            if (isLeft)
            {
                MyPlayer.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            if (isRight)
            {
                MyPlayer.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }

    }
    public void lightOn()
    {
        sceneLight.SetActive(false);
    }
    public void forwardBtnClickedDown()
    {
        isForward = true;
    }
    public void forwardBtnClickedUp()
    {
        isForward = false;
    }
    public void reverseBtnClickedDown()
    {
        isReverse = true;
    }
    public void reverseBtnClickedUp()
    {
        isReverse = false;
    }
    public void leftBtnClickedDown()
    {
        isLeft = true;
    }
    public void leftBtnClickedUp()
    {
        isLeft = false;
    }
    public void rightBtnClickedDown()
    {
        isRight = true;
    }
    public void rightBtnClickedUp()
    {
        isRight = false;
    }
    public void TakeDamage(float percent)
    {
        // Subtract 0.1 (which is 10%)
        currentHealth -= percent;

        // Update the slider
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
            // You can add SceneManager.LoadScene(0) here to restart!
        }
    }
    void Die()
    {
        // 1. Show the Game Over screen
        gameOverPanel.SetActive(true);

        // 2. Turn off the player (so they can't move or shoot)
        // We use transform.root to make sure the whole player vanishes
        gameObject.SetActive(false);

        // 3. Unlock the mouse cursor so you can click the button
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // This is for the button to call
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Intro_Scene"); 
    }





}