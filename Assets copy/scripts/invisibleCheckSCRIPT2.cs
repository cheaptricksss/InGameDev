using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleCheckSCRIPT2 : MonoBehaviour
{
    // public Transform ;
    public GameObject self;
    public GameObject objDestroy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision) { 
        if (collision.gameObject.transform.name == "marbleFollowed")
        {

            // GameObject.Find("marbleFollowed").GetComponent<Transform>().position = GameObject.Find("bowlingBall").GetComponent<Transform>().position;
            Destroy(self);
            Destroy(objDestroy);
            GameObject.Find("MainCamera").GetComponent<cameraSmoothFollow>().target = GameObject.Find("bowlingBall").GetComponent<Transform>();
            
        }
    }
    //MainCamera.GetComponent<cameraSmoothFollow>().move = true;
    //Debug.Log(MainCamera.GetComponent<cameraSmoothFollow>().move);
    //MainCamera.GetComponent<cameraSmoothFollow>().target = NewTarget;
    //Find().GetComponent<cameraSmoothFollow>().target = NewTarget;


}

