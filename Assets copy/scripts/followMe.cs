using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMe : MonoBehaviour
{
    int counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;

    // Start is called before the first frame update
    void Start()
    {
        // counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;
    }

    // Update is called once per frame
    void Update()
    {
        counterTrigger = GameObject.Find("invisibleCheck1").GetComponent<invisibleCheck1>().counter;

        //if(counterTrigger == 1)
        //{

        //}
    }
}
