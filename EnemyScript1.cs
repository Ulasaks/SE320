using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour
{
    private float speed=5.0f;
    public GameObject enemy;
    private int direction=-1;
    private int rotationD=180;
    private Vector3 movement;
    private Vector3 rotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement= new Vector3(direction*speed,0f,0f);
        rotator=new Vector3(0f, rotationD, 0f);
        transform.position+=movement*Time.deltaTime;
        
    }

    public void OnCollisonEnter(Collision collision)
    {
        direction=direction*-1;
        rotationD+=180;
    }
}
