using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class DoorSceneScript : MonoBehaviour
{
    public InputField openDoorInputField;
    public string myText;

    private AudioSource correctInput;

    void Start()
    {
        correctInput = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x - 0.0005f, transform.position.y);

        myText = openDoorInputField.text;

        if (Input.anyKeyDown)
        {
            openDoorInputField.Select();
        }

        if (myText == "look beyond" || myText == "Look Beyond" || myText == "Look beyond")
        {
            correctInput.Play();
            StartCoroutine(SceneChange());

        }

        if (myText == "back out" || myText == "Back Out")
        {
            correctInput.Play();
            StartCoroutine(SceneEndChange());
        }
    }

    IEnumerator SceneChange()
    {

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("EyeScene", LoadSceneMode.Single);
    }

    IEnumerator SceneEndChange()
    {

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("EndingScene2", LoadSceneMode.Single);
    }
}
