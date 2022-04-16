using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllWin2 : MonoBehaviour
{
    public GameObject win, homeButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("Monster"))
        {
            Time.timeScale = 0;
            win.gameObject.SetActive(true);
            homeButton.gameObject.SetActive(true);

        }
    }

    public void homeScene()
    {
        win.gameObject.SetActive(false);
        homeButton.gameObject.SetActive(false);
        SceneManager.LoadScene("Home");
        Waktu2.timeLeft = 0;

    }
}
