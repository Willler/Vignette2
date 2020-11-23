using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class PlayerEyeMovement : MonoBehaviour
{

    private AudioSource correctInput;
    // Start is called before the first frame update
    void Start()
    {
        correctInput = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + 0.005f, transform.position.y);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.005f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        correctInput.Play();
        StartCoroutine(alignedSceneChange());
    }

    IEnumerator alignedSceneChange()
    {
        Debug.Log("Yes");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
    }
}
