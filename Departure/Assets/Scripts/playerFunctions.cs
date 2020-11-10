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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText = mainInputField.text;
        if (myText == "respond") 
        {
            Debug.Log("it worked!");
            SceneManager.LoadScene("EyeScene", LoadSceneMode.Single);
        }
        else if (myText == "waiting to be seen")
        {
            promptText.color = new Color(0.52f, 0f, 0f, 1f);
            Debug.Log("door appears");
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            mainInputField.Select();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            doorSprite.color = new Color(1f, 1f, 1f, 1f);
            knobSprite.color = new Color(0f, 0f, 0f, 1f);
            Debug.Log("door appears");
        }

        if (collision.gameObject.tag == "Knob")
        {
            loreText.color = new Color(0.5f, 0f, 0f, 1f);
            Debug.Log("lore appears");
        }

        if (collision.gameObject.tag == "killZone")
        {
            transform.position = new Vector2(-8.75f, -2.6f);
            Debug.Log("Reset");
 

        }
    }

}
