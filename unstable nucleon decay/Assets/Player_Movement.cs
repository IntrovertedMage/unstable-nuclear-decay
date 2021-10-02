using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{ 

    public Vector3 midPos;
    public float speed;
    public float horizontalSpeed;
    public float verticalSpeed;

    Vector2 direction;

    

    void Start()
    {


        transform.position = midPos - new Vector3(100, 0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Vector3.zero);
        transform.Translate(new Vector3(0,speed * Time.deltaTime * -transform.position.y / 2,speed * Time.deltaTime),Space.Self);

        direction.x = Input.GetAxis("Horizontal");

        direction.y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(direction.x * horizontalSpeed * Time.deltaTime,direction.y * horizontalSpeed * Time.deltaTime ,0),Space.Self);

    }
}
