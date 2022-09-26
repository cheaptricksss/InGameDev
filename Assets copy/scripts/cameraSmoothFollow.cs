using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSmoothFollow : MonoBehaviour
{
    public Transform target;
    // used to destroy the start object
    public GameObject startObject;
    // starting target
    public Transform startFollow;

    public float followSpeed = 0.125f;
    public Vector3 offset;

    // add bowling
    public Transform secondCam;


    public bool move;
    public float speedY = 0.02f;
    public float speedX = 0.02f;
    int counterTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        int counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")){
            Destroy(startObject);
            target = startFollow;
         }
        if (move == true)
        {

            transform.position += new Vector3(speedX, speedY, 0);


        }

        // counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;

        

    }

    private void LateUpdate()
    {
        // if (move == false)
        // {
            transform.position = target.position + offset;
        // }
        if (counterTrigger <= 1)
        {
            transform.position = target.position + offset;
        }
        else if (counterTrigger == 2)
        {
            transform.position = secondCam.position + offset;
        }
        else if (counterTrigger == 3)
        {

        }
        else if (counterTrigger == 4)
        {

        }
        else if (counterTrigger == 5)
        {

        }
    }
}

// when a marble clashes with the toy truck, make its motor speed = 50

   