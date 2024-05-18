using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemies2 : MonoBehaviour
{
    //variables for the game
    Health damage;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        damage = player.GetComponent<Health>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
        }
    }

      void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))      //if the other object is tag as ground
        {
            damage.TakeDamage(1);                      
        }
    }
}
