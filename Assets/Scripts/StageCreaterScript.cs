using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreaterScript : MonoBehaviour
{
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject stage4;

    float timer = 0;
    int interval = 5;
   
    int i = 1;

 

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        int R = Random.Range(1,4);

        timer += Time.deltaTime;

        float zp = 28.7f;


        if (timer >= interval)
            {

            zp = zp * i;

            if (R == 1)
            {
                Instantiate(stage1, new Vector3(-12, -3.5f, zp), transform.rotation);
                timer = 0;
                i += 1;
            }
            if (R == 2)
            {
                Instantiate(stage2, new Vector3(-12, -3.5f, zp), transform.rotation);
                timer = 0;
                i += 1;
            }
            if (R == 3)
            {
                Instantiate(stage3, new Vector3(-12, -3.5f, zp), transform.rotation);
                timer = 0;
                i += 1;
            }
            if (R == 4)
            {
                Instantiate(stage4, new Vector3(-12, -3.5f, zp), transform.rotation);
                timer = 0;
                i += 1;
            }

        }

     
        
    }
}
