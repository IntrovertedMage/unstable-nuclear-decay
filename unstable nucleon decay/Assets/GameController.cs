using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    GameObject player;
    GameObject camera;

    public GameObject alpha;
    public GameObject beta;

    public string[] particleType;

    public LevelSettings level;

    float time = 0;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        camera.GetComponent<Camera>().backgroundColor = level.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Vector3.zero,player.transform.position) < 12)
        {
            Debug.Log("game Won");
            winGame();
        }
        time -= Time.deltaTime;

        if (time <= 0)
        {
            summonRadiation(level.enemies[Random.Range(0,level.enemies.Length)]);
        }

        


    }

    public void lostGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void winGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void summonRadiation(string name)
    {
        float angle = 0;
        float anglex = 0;

        switch (name)
        { 

            case "alpha":
                for (int i = 0; i < level.alphaAmount; i++)
                {
                    angle = Random.Range(0, 360);
                    anglex = Random.Range(-1, 2) * 18f;
                    Instantiate(alpha, Vector3.zero, Quaternion.Euler(new Vector3(0, angle, anglex)));
                    
                }
                time = level.alphaTime;
                break;
            case "beta":
                for (int i = 0; i < level.betaAmount; i++)
                {
                    angle = Random.Range(0, 360);
                    anglex = Random.Range(-1, 2) * 18f;
                    Instantiate(beta, Vector3.zero, Quaternion.Euler(new Vector3(0, angle, anglex)));
                   
                }
                time = level.betaTime;
                break;

        }
    }
}
