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


    public bool move;
    public float speedY = 0.02f;
    public float speedX = 0.02f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")){
            Destroy(startObject);
            target = startFollow;
         }


    }

    private void LateUpdate()
    {
        if (move == false)
        {
            transform.position = target.position + offset;
        }
        if (move == true)
        {

            transform.position += new Vector3(speedX, speedY, 0);


        }
    }
}

// when a marble clashes with the toy truck, make its motor speed = 50

   