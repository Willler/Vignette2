using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class StartMenu : MonoBehaviour
{

    public InputField StartInputField;
    public string myText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText = StartInputField.text;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            StartInputField.Select();
        }

        if (myText == "begin")
        {
            SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
        }
    }
}
