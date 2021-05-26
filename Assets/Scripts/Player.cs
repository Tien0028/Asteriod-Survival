using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    //private bool shieldPower;
    public GameObject shield;
    //private PowerUp powerUp;
    private EnableShield enableShield;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        enableShield = this.GetComponent<EnableShield>();
        enableShield.SetActive(false);
    }

    // Update is called once per frame, and is usual for detecting inputs
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;


    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

}
