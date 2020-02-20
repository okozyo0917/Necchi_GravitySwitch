using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ColliderScript2 : MonoBehaviour
{
    public float speed = 3.0f;

    public GameObject Explotion;
    public GameObject gameOver;
    public Text gameOverScore; //gameover時に表示されるスコア
    public int highScore;
    private string key = "HIGH SCORE";

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(key,0);
        gameOverScore.text = "HighScore : " + highScore.ToString();
        Explotion.GetComponent<ParticleSystem>().Stop();

    }

    // Update is called once per frame
    void Update()
    {
    


    }


    void OnTriggerStay(Collider other)
    {
 

        if (other.gameObject.tag =="Wakk")
        {

            GameObject player = GameObject.Find("Player");
            gameObject.transform.parent = null;
            Explotion.GetComponent<ParticleSystem>().Play();
            gameOver.SetActive(true);

            //gameOverScore.GetComponent<Text>().text = "HighScore : " + ScoreScript.Count.ToString();

           Destroy(player);
           CameraScript.camerazero=0;

            Debug.Log("Break");


            if (Input.GetMouseButtonUp(0))
            {
                Application.LoadLevel("GAME");
                ScoreScript.Count = 0;
            }

            if (ScoreScript.Count > highScore)
            {
                highScore = ScoreScript.Count;
                PlayerPrefs.SetInt(key,highScore);
                gameOverScore.text = "HighScore : " + highScore.ToString();
            }




        }


 



    }
}
