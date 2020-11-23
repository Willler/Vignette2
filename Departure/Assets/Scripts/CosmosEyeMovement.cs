using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmosEyeMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.localScale += new Vector3(0.0001f, 0.0001f, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - 0.005f, transform.position.y);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.005f);
        }
    }
}
