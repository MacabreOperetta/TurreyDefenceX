﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

    public GameObject ui;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyUp(KeyCode.P))
        {
            Toggle();
        }
	}
    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);
        if(ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
