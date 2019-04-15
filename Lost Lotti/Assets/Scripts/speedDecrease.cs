using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedDecrease : MonoBehaviour
{
    //	public GameObject rewardObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //		Instantiate(rewardObject, transform.position, Quaternion.identity);
            playerControllerScript mySpeed = other.gameObject.GetComponent<playerControllerScript>();
            mySpeed.decreaseSpeed();
            Destroy(transform.root.gameObject);
        }
    }
}
