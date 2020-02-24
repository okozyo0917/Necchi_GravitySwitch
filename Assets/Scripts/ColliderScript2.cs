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
    public GameObject ScoreDelete;
    public Text gameOverScore; //gameover時に表示されるスコア
    public int highScore;
    private string key = "HIGH SCORE";
    public GameObject player;

    int scene = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        highScore = PlayerPrefs.GetInt(key,0);
        gameOverScore.text = "HighScore : " + highScore.ToString();
        Explotion.GetComponent<ParticleSystem>().Stop();


    }

    // Update is called once per frame
    void Update()
    {

        if (scene == 1)
        {
            if (Input.GetMouseButtonUp(0))
            {
                SceneManager.LoadScene("GAME");
                ScoreScript.Count = 0;
            }
        }

    }


    void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.tag =="Wakk")
        {

           
            GameObject ScoreDelete = GameObject.Find("Score");
            gameObject.transform.parent = null;
            Explotion.GetComponent<ParticleSystem>().Play();
            gameOver.SetActive(true);

            //gameOverScore.GetComponent<Text>().text = "HighScore : " + ScoreScript.Count.ToString();

           Destroy(player);
           Destroy(ScoreDelete);
           CameraScript.camerazero=0;

            scene = 1;
            Debug.Log("Break");



            if (ScoreScript.Count > highScore)
            {
                highScore = ScoreScript.Count;
                PlayerPrefs.SetInt(key,highScore);
                gameOverScore.text = "HighScore : " + highScore.ToString();
            }

   


        }


 



    }
}
