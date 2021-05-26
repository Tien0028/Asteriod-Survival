using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private GameObject player;
    public float shieldDuration = 4f;
    private bool shieldPower;
    //[SerializeField]private GameObject shield;
    private GameObject shield;
    private EnableShield enableShield;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enableShield = player.GetComponent<EnableShield>();
        
        shieldPower = false;

        enableShield.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {

            Debug.Log("Power Up taken");
            Destroy(this.gameObject);
            if (!shieldPower)
            {
                enableShield.SetActive(true);
                shieldPower = true;
                Destroy(this.gameObject);
            }
            else
            {
                enableShield.SetActive(false);
                shieldPower = false;
            }



        }
    }

}
