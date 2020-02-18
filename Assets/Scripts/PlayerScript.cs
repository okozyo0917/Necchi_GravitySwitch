using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        
    }


    void OnCollisionStay(Collision col)
    {
       

        if (Input.GetMouseButtonDown(0))
        {
            Physics.gravity = new Vector3(0, 9.8f, 0);

            if (transform.position.y >2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Physics.gravity = new Vector3(0, -9.8f, 0);

                }
            }
            

        }
    }
}
