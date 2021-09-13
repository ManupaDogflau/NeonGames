using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject main;
    public GameObject credits;
    public GameObject htp;// Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Return()
    {
        main.SetActive(true);
        credits.SetActive(false);
        htp.SetActive(false);
    }
    public void Credits()
    {
        credits.SetActive(true);
        main.SetActive(false);
        htp.SetActive(false);
    }
    public void Htp()
    {
        htp.SetActive(true);
        main.SetActive(false);
        credits.SetActive(false);
    }
}
