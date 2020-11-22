using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundPeopleMovement : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + 0.006f, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "killZone")
        {
            transform.position = new Vector2(-8.75f, -2.6f);
        }
    }
}
