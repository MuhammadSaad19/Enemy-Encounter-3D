using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PistolHandler : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform muzzle;        
    //public float bulletSpeed = 20f;

    public GameObject reloadBtn;




    int loadedBullets, TotalBullets;

    public Text bulletCounter;

    void Start()
    {

        loadedBullets = 6;
        TotalBullets = 19;

        bulletCounter.text = loadedBullets + "/" + TotalBullets;
        reloadBtn.SetActive(false);

    }




    

    
    //public void FirePistol()
    //{
       

    //    //GameObject newBullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);

    //    //Rigidbody rb = newBullet.GetComponent<Rigidbody>();
    //    //rb.velocity = muzzle.forward * bulletSpeed;

       
    

    //    //Debug.Log("Pistol Fired!");
    //}

    public void fireBtnClicked()
    {

        if (loadedBullets != 0)
        {
            GameObject newBullet =    Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);

            //Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            //rb.velocity = muzzle.forward * bulletSpeed;


            loadedBullets--;
            bulletCounter.text = loadedBullets + "/" + TotalBullets;
            if (loadedBullets == 0)
                reloadBtn.SetActive(true);
        }


    }
            

    public void reloadBtnClicked()
    {
        if (TotalBullets != 0)
        {
            // TotalBullets= TotalBullets-6;

            if (TotalBullets >= 6)
            {
                loadedBullets = 6;
                TotalBullets = TotalBullets - 6;
            }
            else
            {
                loadedBullets = TotalBullets;
                TotalBullets = TotalBullets - loadedBullets;
            }

            bulletCounter.text = loadedBullets + "/" + TotalBullets;

            reloadBtn.SetActive(false);


        }
    }

   
}
