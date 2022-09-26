using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleCheck1 : MonoBehaviour
{
    public int counter;
    // public GameObject marbelFollowed;
    //public Transform NewTarget;
    public GameObject objectToDestroy;
    public GameObject self;
    // will be true when the follow code for the camera is written
    //public bool follow;
    
    //Camera MainCamera;

    public string objName;
    //Vector3 go;

    // AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        objName = "marbleFollowed";
        // mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name == objName)
        {

            
            // mySource.Play();
            Destroy(objectToDestroy);
            Destroy(self);


            //MainCamera.GetComponent<cameraSmoothFollow>().move = true;
            //Debug.Log(MainCamera.GetComponent<cameraSmoothFollow>().move);
            //MainCamera.GetComponent<cameraSmoothFollow>().target = NewTarget;
            //Find().GetComponent<cameraSmoothFollow>().target = NewTarget;
            

        }


    }
}
