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

        if (Input.anyKeyDown)
        {
            StartInputField.Select();
        }

        if (myText == "begin" || myText == "Begin")
        {
            StartInputField.text = "";
            SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
        }
    }
}
