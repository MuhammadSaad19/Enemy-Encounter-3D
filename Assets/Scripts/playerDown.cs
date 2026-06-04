using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDown : MonoBehaviour
{
   
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("dg");
           // Destroy(gameObject);
        }
       // other.gameObject.SetActive(false);
        

        //if (gameObject.Tag == "enemey") { 
        //    other.SetActive(false);
        //}
    }
   

}
