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
    bool isPressed;
    // add bowling
    //public Transform secondCam;


    //public bool move;
    //public float speedY = 0.02f;
    //public float speedX = 0.02f;
    //int counterTrigger;

    public AudioClip sound;
    AudioSource spacePressed;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        spacePressed = GetComponent<AudioSource>();
        //int counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isPressed == false){
            Destroy(startObject);
            
            target = startFollow;
            spacePressed.Play();
            isPressed = true;
            Destroy(text);
        }
        //if (move == true)
        //{

            //transform.position += new Vector3(speedX, speedY, 0);


        //}

        // counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;

        

    }

    private void LateUpdate()
    {
        // if (move == false)
        // {
            transform.position = target.position + offset;
        // }
       
    }
}

// when a marble clashes with the toy truck, make its motor speed = 50

   