﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class StitchesBehavior : MonoBehaviour
{
    public InputField stitchesInputField;
    public string myText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText = stitchesInputField.text;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            stitchesInputField.Select();
        }

        if (myText == "fear of the unknown")
        {
            Destroy(GameObject.FindWithTag("StitchLayer1"));

        } else if (myText == "a placid island of ignorance")
        {
            Destroy(GameObject.FindWithTag("StitchLayer2"));
        }
        else if (myText == "often paralyses memory")
        {
            Destroy(GameObject.FindWithTag("StitchLayer3"));
        }
        else if (myText == "a seeker, a dreamer")
        {
            Destroy(GameObject.FindWithTag("StitchLayer4"));
        }
    }
}