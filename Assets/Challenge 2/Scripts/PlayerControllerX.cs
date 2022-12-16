using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float collingTime = 20.0f;
    // Update is called once per frame
    void Update()
    {
        collingTime -= 0.1f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && collingTime <= 0.0f)
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            collingTime = 20.0f;
        }
    }
}
