﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScreenController : MonoBehaviour
{
    private void Update()
    {
        if(GameManager.UI.ScoreSceenActive)
        {

            if (Input.GetAxisRaw("Cancel") != 0)
            {
                PlayerPrefs.SetInt("RedMatchPoints", 0);
                PlayerPrefs.SetInt("BlueMatchPoints", 0);

                SceneManager.LoadScene(0);
            }

            if (Input.GetAxisRaw("Submit") != 0)
            {
                //SceneManager.LoadScene(1);
                GameManager.UI.ShowMatchScreen();
            }
        }
    }
}
