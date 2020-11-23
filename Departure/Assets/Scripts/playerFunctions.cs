using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class playerFunctions : MonoBehaviour
{
    public InputField mainInputField;
    public string myText;

    public SpriteRenderer doorSprite;
    public SpriteRenderer knobSprite;
    public Text promptText;
    public Text loreText;

    private bool answeredPrompt;
    private bool loreAnswered;


    void Start()
    {
        answeredPrompt = false;
        loreAnswered = false;
    }

    // Update is called once per frame
    void Update()
    {
        myText = mainInputField.text;
        if (myText == "respond" || myText == "Respond") 
        {
            Debug.Log("it worked!");
            
            mainInputField.text = "";
            SceneManager.LoadScene("DoorScene", LoadSceneMode.Single);

        }
        else if (myText == "waiting")
        {
            
            loreAnswered = true;
            Debug.Log("prompt appears");
            mainInputField.text = "";
        }
        else if (myText == "Ignore" || myText == "ignore")
        {
            answeredPrompt = true;
            loreText.color = new Color(0.5f, 0f, 0f, 0f);
            promptText.color = new Color(0.52f, 0f, 0f, 0f);
            mainInputField.text = "";
        }

        if (Input.anyKeyDown)
        {
            mainInputField.Select();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door" && loreAnswered == true)
        {
            doorSprite.color = new Color(1f, 1f, 1f, 1f);
            knobSprite.color = new Color(0f, 0f, 0f, 1f);
            promptText.color = new Color(0.52f, 0f, 0f, 1f);
            Debug.Log("door appears");
        }

        if (collision.gameObject.tag == "Knob")
        {
            loreText.color = new Color(0.5f, 0f, 0f, 1f);
            Debug.Log("lore appears");
        }

        if (collision.gameObject.tag == "killZone" && answeredPrompt == false)
        {
            transform.position = new Vector2(-8.75f, -2.6f);
            Debug.Log("Reset");
 

        } else if (collision.gameObject.tag == "killZone" && answeredPrompt == true)
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            doorSprite.color = new Color(1f, 1f, 1f, 0f);
            knobSprite.color = new Color(0f, 0f, 0f, 0f);
            Debug.Log("door disappears");
        }

        if (collision.gameObject.tag == "Knob")
        {
            loreText.color = new Color(0.5f, 0f, 0f, 0f);
            promptText.color = new Color(0.52f, 0f, 0f, 0f);
            Debug.Log("lore disappears");
        }
    }

}
