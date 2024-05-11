using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health2 : MonoBehaviour
{
    //variables for the game
    public int maxhealth;
    public int currentHealth;
    public GameObject hp1;
    public GameObject hp2;

    //Start is called before the first frame update
    void Start()
    {
        maxhealth = 2;
        currentHealth = maxhealth;
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
