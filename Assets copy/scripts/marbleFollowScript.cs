using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marbleFollowScript : MonoBehaviour
{
    // Start is called before the first frame update

    public bool check;

    public float speedY = 0.01f;
    public float speedX = 0.02f;
    Vector3 currentPosition ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

           // if (check == true)
           // {
           //     transform.position += new Vector3(speedX, speedY, 0);
           // }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name == "invisibleCheck2")
        {
            Debug.Log("Hit");
            check = true;
            // GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
            // GetComponent<Rigidbody>().
            // GetComponent<Collider>().isTrigger = true;

        }


    }
}
