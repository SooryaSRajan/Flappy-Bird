using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject startingScreen;
    public GameObject scoreScreen;
    public GameObject pauseScreen;
    public GameObject resumeScreen;
    public GameObject bird;

    public static bool isStart = true; 
    // Start is called before the first frame update
    void Start()
    {
        if(isStart){
            bird.gameObject.SetActive(false);
            startingScreen.SetActive(true);
            pauseScreen.SetActive(false);
            scoreScreen.SetActive(false);
            Time.timeScale = 0;
        }
        else{
            startingScreen.SetActive(false);
            pauseScreen.SetActive(true);
            scoreScreen.SetActive(true);
            bird.gameObject.SetActive(true);
            Time.timeScale = 1;
        }
            gameOverScreen.SetActive(false); 
            resumeScreen.SetActive(false);      

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LaunchGame(){
        startingScreen.SetActive(false);
        pauseScreen.SetActive(true);
        bird.gameObject.SetActive(true);
        resumeScreen.SetActive(false);
        scoreScreen.SetActive(true);
        Time.timeScale = 1;
    }

    public void RestartGame(){
        isStart = false;
        SceneManager.LoadScene(0);
    }

    public void GameOver(){
        scoreScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        pauseScreen.SetActive(false);
        resumeScreen.SetActive(false);
        Time.timeScale = 0;
    }

    
    public void PauseGame(){
        Time.timeScale = 0;
        pauseScreen.SetActive(false);
        resumeScreen.SetActive(true);
    }

    public void ResumeGame(){
        Time.timeScale = 1;
        pauseScreen.SetActive(true);
        resumeScreen.SetActive(false);
    }
}
