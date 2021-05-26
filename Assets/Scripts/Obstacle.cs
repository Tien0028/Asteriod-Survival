using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    private EnableShield enableShield;
    private GameObject shield;
    private bool shieldPower;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player != null)
        {
            enableShield = player.GetComponent<EnableShield>();
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Debug.Log(player.gameObject.name + " Collision");
            if (enableShield.isActive())
            {
                Debug.Log("Shield Down");
                Destroy(this.gameObject);
                enableShield.SetActive(false);
                
            }
            else
            {
                Destroy(player.gameObject);
            }


        }


    }
}
