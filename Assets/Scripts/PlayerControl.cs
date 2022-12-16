using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20.0f;
    public float xRange = 20.0f;
    public float zRangeBottom = -5.0f;
    public float zRangeTop = 15.0f;
    public GameObject projectilePrefab;
    private int life = 3;
    public int Life
    {
        get { return life; }
        set { life = value; }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // make sure the player moves between the negative xRange to postive xRange
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        else if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        else if (transform.position.z > zRangeTop)
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        else if (transform.position.z < zRangeBottom)
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBottom);
        horizontalInput = Input.GetAxis("Horizontal"); // control the player with the arrow left/right
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
