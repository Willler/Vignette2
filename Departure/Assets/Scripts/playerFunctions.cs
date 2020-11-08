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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText = mainInputField.text;
        if (myText == "open" || myText == "respond") 
        {
            Debug.Log("it worked!");
            SceneManager.LoadScene("EyeScene", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log(" Blerg!");
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
            Debug.Log("door appears");
        }

        if (collision.gameObject.tag == "killZone")
        {
            transform.position = new Vector2(-8.75f, -2.6f);
            Debug.Log("Reset");
 

        }
    }

}
