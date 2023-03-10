using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float rightBound = 24.0f;
    private float leftBound = -24.0f;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        } else if (transform.position.x > rightBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        } else if (transform.position.x < leftBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
