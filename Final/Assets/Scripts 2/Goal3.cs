using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal3 : MonoBehaviour
{
    //Called when a Collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))  //if the object colliding with is the player
        {
            SceneManager.LoadScene("GameOver");       //Move object to GameOver
        }
    }
}
