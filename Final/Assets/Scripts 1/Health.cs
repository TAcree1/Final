using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //variables for hte game
    public int maxhealth;       //max amount of health a player can have
    public int currentHealth;   //tracks current health of the player
    public GameObject hp1;      //First hp block
    public GameObject hp2;      //Second hp block

    // Start is called before the first frame update
    void Start()
    {
        maxhealth = 2;                  //set max health at 2
        currentHealth = maxhealth;      //set current heatlh to max health (2)
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;        //Lower health

        if (currentHealth ==2)                  //if health equal 2
        {
            hp2.SetActive(false);               //Nothing happens
        }
        if (currentHealth ==1)                  //if health equal 1
        {
            hp1.SetActive(false);               //nothing happens
        }
        if (currentHealth <= 0)                 //if health equal 0
        {
            SceneManager.LoadScene("GameOver");  //go to GameOver Scene
        }
    }
}
