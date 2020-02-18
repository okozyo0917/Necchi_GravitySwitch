using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(5, 5, 5));
    }



    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        ScoreScript.Count += 1;
        Debug.Log("ITEMGET");

    }
}
