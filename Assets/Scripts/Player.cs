using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public int curHealth;
    public int maxHealth = 5;

    public DeathMenu deathMenu;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        

    }

    // Update is called once per frame
    void Update()
    {
        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if(curHealth <= 0)
        {
            Die();
        }

        
    }

    void Die()
    {
        //SceneManager.LoadScene("Mainmenu", LoadSceneMode.Single);
        //Score.scoreValue = 0;

        deathMenu.ToggleDeathMenu();
      
    }

    public void Damage(int dmg)
    {
        curHealth -= dmg;
    }

}
