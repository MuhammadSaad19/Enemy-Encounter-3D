using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public float bulletSpeed; // Adjust this in the Inspector

    void Update()
    {

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + bulletSpeed);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // 1. Find the GameManager script in your scene
            // Replace 'GameManager' with the actual class name if it's different
            GameManager gm = GameObject.FindObjectOfType<GameManager>();

            if (gm != null)
            {
                // 2. Call your existing function!
                gm.scoreCounter();
            }

            // 3. Kill the enemy and hide the bullet
            Destroy(other.transform.root.gameObject);
            gameObject.SetActive(false);
        }
    }
}