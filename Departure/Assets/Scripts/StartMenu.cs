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

    private AudioSource correctInput;

    void Start()
    {
        correctInput = GetComponent<AudioSource>();
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
            correctInput.Play();
            StartCoroutine(LoadScene());
           
        }
    }

    IEnumerator LoadScene()
    {
        
        yield return new WaitForSeconds(0.5f);
        StartInputField.text = "";
        
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }
}
