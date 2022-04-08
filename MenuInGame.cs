using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInGame : MonoBehaviour
{
   public GameObject gameMenu,pauseMenu;
    void Start()
    {
        
    }

    
    void Update()
    {
       
    }
    public void PauseButton()
    {
       Time.timeScale=0; 
       gameMenu.SetActive(false);
       pauseMenu.SetActive(true);
    }
    public void playButton()
    {
        Time.timeScale=1; 
        gameMenu.SetActive(true);
       pauseMenu.SetActive(false);

    }
    public void restartButton()
    {
        Time.timeScale=1; 
        SceneManager.LoadScene(1);
    }
    public void menuButton()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(0);

    }









}
