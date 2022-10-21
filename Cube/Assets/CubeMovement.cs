using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CubeMovement : MonoBehaviour
{
    public Transform cube;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            cube.Translate(-cube.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.Translate(cube.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            cube.Translate(cube.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cube.Translate(-cube.forward * speed * Time.deltaTime);
        }

        
    }
}
