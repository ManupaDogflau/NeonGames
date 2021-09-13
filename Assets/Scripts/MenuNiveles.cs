using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{
    [SerializeField] private GameObject pause;

    [SerializeField] private GameObject victory;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private AudioSource victoryAudio;
    public static MenuNiveles Instance { get; private set; }// Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 1f)
            {
                Pause();
            }
        }
    }

    public void Next()
    {
        Time.timeScale = 1f;
        if (SceneManager.GetActiveScene().buildIndex + 1 >= SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Resete()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pause.SetActive(true);
        victory.SetActive(false);
        pauseButton.SetActive(false);
    }

    public void Continue()
    {
        Time.timeScale = 1f; 
        pause.SetActive(false);
        victory.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void Victory()
    {
        Time.timeScale = 0f;
        pause.SetActive(false);
        victory.SetActive(true);
        pauseButton.SetActive(false);
        victoryAudio.Play();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
