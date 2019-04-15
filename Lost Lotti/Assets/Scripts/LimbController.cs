using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimbController : MonoBehaviour {
    //public GameObject rewardObject;
    void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
            print("limb!");
            //Instantiate(rewardObject, transform.position, Quaternion.identity);
            other.gameObject.GetComponent<playerHealth>().addLimb();
            //other.gameObject.GetComponent<playerHealth>().addHealth(1);

            Destroy(transform.gameObject);
        }
	}
    
}
