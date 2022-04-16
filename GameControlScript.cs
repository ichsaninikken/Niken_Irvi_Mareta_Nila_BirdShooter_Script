using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    public GameObject timeIsUp, restartButton, homeButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Waktu.timeLeft <= 0)
        {
            Time.timeScale = 0;
            timeIsUp.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            homeButton.gameObject.SetActive(true);
        }
    }

    public void restartScene()
    {
        timeIsUp.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        homeButton.gameObject.SetActive(false);
        Time.timeScale = 1;
        Waktu.timeLeft = 15f;
        SceneManager.LoadScene("Level1");
    }

    public void homeScene()
    {
        timeIsUp.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        homeButton.gameObject.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Home");
    }
}
