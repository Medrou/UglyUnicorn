using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    
    public Text scoreText;
   
    
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
       scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public void ToggleDeathMenu()
    {
        //gameObject.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Ugly Unicorn");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
