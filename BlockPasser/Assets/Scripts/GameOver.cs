using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour

{

    public GameObject gameOverScreen;
    public Text secondsServivedUI;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene (0);
            }

            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

    }

    public void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        secondsServivedUI.text = Mathf.Round(Time.timeSinceLevelLoad).ToString();
        gameOver = true;
    }
}
