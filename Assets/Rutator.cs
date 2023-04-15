using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Rutator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.up);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Quaternion rotationY = Quaternion.AngleAxis(-1, Vector3.up);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.right);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Quaternion rotationY = Quaternion.AngleAxis(-1, Vector3.right);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion rotationY = Quaternion.AngleAxis(1, new Vector3(0,0,1));
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion rotationY = Quaternion.AngleAxis(-1, new Vector3(0, 0, 1));
            transform.rotation *= rotationY;
        }
    }
}
