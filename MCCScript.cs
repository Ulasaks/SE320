using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCCScript : MonoBehaviour
{
    private float rotateSpeed=20.0f;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.down*rotateSpeed*Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime);
        }
    }
}
