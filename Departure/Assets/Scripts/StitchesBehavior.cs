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

    
    private bool stitch1 = false;
    private bool stitch2 = false;
    private bool stitch3 = false;
    private bool stitch4 = false;

    public GameObject openEyePrefab;

    Vector2 eye1Position;
    Vector2 eye2Position;

    private bool isCreated;

    private AudioSource correctInput;


    void Start()
    {
        eye1Position = new Vector2(-3.64f, -1.38f);
        eye2Position = new Vector2(4, -1.38f);
        correctInput = GetComponent<AudioSource>();
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
            correctInput.Play();
            yield return new WaitForSeconds(0.5f);
            Destroy(GameObject.FindWithTag("StitchLayer1"));
            
            stitch1 = true;
            yield return new WaitForSeconds(0.5f);
            stitchesInputField.text = "";

        }
        else if (myText == "island of ignorance" || myText == "Island of ignorance")
        {
            correctInput.Play();
            yield return new WaitForSeconds(0.5f);
            Destroy(GameObject.FindWithTag("StitchLayer2"));
            
            stitch2 = true;
            yield return new WaitForSeconds(0.5f);
            stitchesInputField.text = "";
        }
        else if (myText == "often paralyses memory" || myText == "Often paralyses memory")
        {
            correctInput.Play();
            yield return new WaitForSeconds(0.5f);
            Destroy(GameObject.FindWithTag("StitchLayer3"));
            
            stitch3 = true;
            yield return new WaitForSeconds(0.5f);
            stitchesInputField.text = "";
        }
        else if (myText == "a seeker, a dreamer" || myText == "A seeker, a dreamer")
        {
            correctInput.Play();
            yield return new WaitForSeconds(0.5f);
            Destroy(GameObject.FindWithTag("StitchLayer4"));
            
            stitch4 = true;
            yield return new WaitForSeconds(0.5f);
        
            stitchesInputField.text = "";

            yield return new WaitForSeconds(3f);

            if (stitch1 == true && stitch2 == true && stitch3 == true && stitch4 == true)
            {
                if (!isCreated)
                {
                    Instantiate(openEyePrefab, eye1Position, Quaternion.identity);
                    Instantiate(openEyePrefab, eye2Position, Quaternion.identity);
                    isCreated = true;
                }

                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene("AlignScene", LoadSceneMode.Single);
            } else {
                
                Debug.Log("works");
                SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            }


        }

    }
    }
