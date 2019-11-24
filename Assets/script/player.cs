using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour { 

    public float speed = 0;
    public float jumpHeight = 0;
    public Rigidbody rb;
    //public bool onGround = false; //Before the game ran the player is not on the ground.

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.FindObjectOfType<Rigidbody>(); //When we run the game we can access and influence the object's laws of physics (happens once at the beginning of the game)
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += new Vector3(0, jumpHeight, 0);
            //onGround = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector3(speed/8,0,0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity += new Vector3(-speed/8, 0, 0);
        }

      //  void OnCollisionEnter(Collision c)
        //{
         //   if(c.gameObject.tag == "Base")
          //  {
                //onGround = true;
          //  }
        }
    }

