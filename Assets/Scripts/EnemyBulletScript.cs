using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBulletScript : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - bulletSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the enemy bullet hit the Player
        if (other.CompareTag("Player"))
        {
            PlayerScript health = other.gameObject.GetComponent<PlayerScript>();

            if (health != null)
            {
                health.TakeDamage(0.1f); // Reduce by 10%
            }

            // Destroy the bullet after it hits the player
            Destroy(gameObject);
        }
    }
}
