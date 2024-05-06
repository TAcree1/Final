using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies2 : MonoBehaviour
{
    //variables for the game
    Health2 damage;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        damage = player.GetComponent<Health2>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
        }

    }
}
