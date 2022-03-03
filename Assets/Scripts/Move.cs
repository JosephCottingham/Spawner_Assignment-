using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yRoation = 0;
        if (Input.GetKey(KeyCode.A))
        {
            yRoation += 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            yRoation -= 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, yRoation, 0);
            rb.AddRelativeForce(new Vector3(-10, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, yRoation, 0);
            rb.AddRelativeForce(new Vector3(5, 0, 0));
        }
    }
}
