using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateImageScript : MonoBehaviour
{
    public GameObject backgroundCosmos;

    public float zAngle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backgroundCosmos.transform.Rotate(Vector3.forward * - 0.05f);
    }
}
