using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour // heritage
{
    public float speed = 5.0f;

    public float turnSpeed = 25.0f;

    private float horizontalInput;

    private float fowardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal"); // change de valeur lorsque l'on appuie sur "q" ou "d"
        fowardInput = Input.GetAxis("Vertical");
        
        // We move the vehicle forward
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * (Time.deltaTime * speed*fowardInput)); // 20 unités / secondes
        
        // We turn the vehicle
        //transform.Translate(Vector3.right * (Time.deltaTime * turnSpeed*horizontalInput));
        transform.Rotate(Vector3.up *(Time.deltaTime * turnSpeed*horizontalInput) );
    }
}
