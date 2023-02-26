using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speedX = 3;
    public float speedY = 3;
    float directionX = 1;
    float directionY = 1;


    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.position += speedY * directionY * Time.deltaTime * Vector3.up;
        transform.position += speedX * directionX * Time.deltaTime * Vector3.right;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            speedY += Random.Range(0.05f, 0.1f);
            directionY = -directionY;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            speedX += Random.Range(0.1f, 0.2f);
            directionX = -directionX;
        }
    }
}
