using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript2 : MonoBehaviour
{
    public GameObject timeIsUp, restartButton2, homeButton2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Waktu2.timeLeft <= 0)
        {
            Time.timeScale = 0;
            timeIsUp.gameObject.SetActive(true);
            restartButton2.gameObject.SetActive(true);
            homeButton2.gameObject.SetActive(true);
        }
    }

    public void restartScene2()
    {
        timeIsUp.gameObject.SetActive(false);
        restartButton2.gameObject.SetActive(false);
        homeButton2.gameObject.SetActive(false);
        Time.timeScale = 1;
        Waktu2.timeLeft = 15f;
        SceneManager.LoadScene("Level2");
    }

    public void homeScene2()
    {
        timeIsUp.gameObject.SetActive(false);
        restartButton2.gameObject.SetActive(false);
        homeButton2.gameObject.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Home");
    }
}
