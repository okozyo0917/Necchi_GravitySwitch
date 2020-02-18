using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Scorelabel;
    public static int Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimerCount", 5.00f, 5.00f);
    }

    // Update is called once per frame
    void Update()
    { Scorelabel.text = Count.ToString();




    }

    public void TimerCount()
    {
        Count += 1;
        Debug.Log(Count);
    }

}
