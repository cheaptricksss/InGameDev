using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    public GameObject colided;
    public GameObject colided2;
    // public AudioClip sound;
    
    AudioSource mySource;
    
    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject == colided ||
          collision.gameObject == colided2)
        {
            mySource.Play();
        }
    }
}
