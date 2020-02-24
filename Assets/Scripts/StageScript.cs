using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       // player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        if (player == null)
        {
            return;
        }
        if (transform.position.z-player.transform.position.z<=-30) {
            Destroy(gameObject);
        }
    }
}
