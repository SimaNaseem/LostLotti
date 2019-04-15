using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{

    //	public GameObject rewardObject;

    public float damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //		Instantiate(rewardObject, transform.position, Quaternion.identity);
            playerHealth myHealth = other.gameObject.GetComponent<playerHealth>();
            myHealth.addDamage(damage);
            myHealth.addRuby();
            Destroy(transform.root.gameObject);
        }
    }
}
