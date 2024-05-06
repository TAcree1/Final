using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables for the game
    float speed;        //Move Speed
    float move;         //direction of movement
    float jump;         //how high the jump is
    bool isJumping;     //tracks if the object is jumping or not
    Rigidbody2D rb;     //place to store the rigidbody of the object
    public static PlayerMovement instance;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;        //set speed value to 10
        jump = 400f;        //set jump value to 200

        rb = GetComponent<Rigidbody2D>();       //store the rb of the object
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");     //move the player 

        rb.velocity = new Vector2(speed * move, rb.velocity.y);     //mvoe one the xaxis (left or right)

        if (Input.GetButtonDown ("Jump") && !isJumping)     //when the unity jump keybind is pressed and if the object is not already 
        {
            rb.AddForce (new Vector2(rb.velocity.x, jump));     //jump
            isJumping = true;                                   //set jumping to true
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))      //if the other object is tag as ground
        {
            isJumping = false;                          //set jumping to false
        }
    }
}
