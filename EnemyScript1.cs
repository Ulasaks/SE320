using System.Diagnostics;
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

    private Ray ray=new Ray(transform.position, transform.forward);
    // Start is called before the first frame update
    void Start()

    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movement= new Vector3(direction*speed,0f,0f);
        
        transform.position+=movement*Time.deltaTime;
        
        transform.eulerAngles= new Vector3(0f,rotationD,0f);
        
    }

    public void OnCollisionEnter(Collision target)
    {
       if((target.gameObject.tag=="Wall")&&(target.transform.position.x<transform.position.x)){

        UnityEngine.Debug.Log("Hi");
        direction=1;
        rotator=new Vector3(0f, rotationD, 0f);
        
        rotationD=0;
        }

        if((target.gameObject.tag=="Opposite Wall")&&(target.transform.position.x>transform.position.x))
        {
        UnityEngine.Debug.Log("Hi");
        direction=-1;
        rotator=new Vector3(0f, rotationD, 0f);
        
        rotationD=180;
        }
    }
}
