using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemyObj;
    public float enemySpeed;
    public GameObject EnemyBullet;
    public GameObject enemyBulletPOS;
    public Transform muzzle;
    // Start is called before the first frame update
    void Start()
    {
        //  enemyObj.SetActive(false);
        //gameObject.SetActive(true);

        //Invoke("bulletFire",3f);
        InvokeRepeating("bulletFire", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //// 1. Calculate the Left/Right swing (X)
        //// Mathf.Sin moves between -1 and 1. We multiply by 3 to make it wider.
        //float x = Mathf.Sin(Time.time * 2f) * 3f;

        //// 2. Calculate the Forward movement (Z)
        //float z = enemyObj.transform.position.z - enemySpeed;

        // 3. Update the position
        //enemyObj.transform.position = new Vector3(enemyObj.transform.position.x, enemyObj.transform.position.y, z);
            enemyObj.transform.Translate(Vector3.back * enemySpeed * Time.deltaTime);
    }

    public void bulletFire()
    {
        GameObject enemyBullet=  Instantiate(EnemyBullet, muzzle.position, muzzle.rotation);
        
    }

}
