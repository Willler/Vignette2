using System.Collections;
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

    private bool stitchesGone = false;

    public GameObject openEyePrefab;

    Vector2 eye1Position;
    Vector2 eye2Position;

    private bool isCreated;


    void Start()
    {
        eye1Position = new Vector2(-3.64f, -1.38f);
        eye2Position = new Vector2(4, -1.38f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {
            stitchesInputField.Select();
        }

        StartCoroutine(stitchesRemoval());
    }


    IEnumerator stitchesRemoval()
    {
        myText = stitchesInputField.text;

 

        if (myText == "fear of the unknown" || myText == "Fear of the unknown")
        {
            Destroy(GameObject.FindWithTag("StitchLayer1"));
            
            yield return new WaitForSeconds(0.5f);
            stitchesInputField.text = "";

        }
        else if (myText == "island of ignorance" || myText == "Island of ignorance")
        {
            Destroy(GameObject.FindWithTag("StitchLayer2"));
            yield return new WaitForSeconds(0.5f);
            stitchesInputField.text = "";
        }
        else if (myText == "often paralyses memory" || myText == "Often paralyses memory")
        {
            Destroy(GameObject.FindWithTag("StitchLayer3"));
            yield return new WaitForSeconds(0.5f);
            stitchesInputField.text = "";
        }
        else if (myText == "a seeker, a dreamer" || myText == "A seeker, a dreamer")
        {
            Destroy(GameObject.FindWithTag("StitchLayer4"));
          
            yield return new WaitForSeconds(0.5f);
        
            stitchesInputField.text = "";

            yield return new WaitForSeconds(3f);

            if (!isCreated)
            {
                Instantiate(openEyePrefab, eye1Position, Quaternion.identity);
                Instantiate(openEyePrefab, eye2Position, Quaternion.identity);
                isCreated = true;
            }

            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("AlignScene", LoadSceneMode.Single);


        }

    }
    }
