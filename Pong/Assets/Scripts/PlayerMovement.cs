using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public KeyCode up;
    public KeyCode down;

    public float speed = 1;

    Camera mainCamera;
    BoxCollider2D box;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        box = GetComponentInChildren<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpMovement();
        DownMovement();
    }

    public void UpMovement()
    {
        float boxY = box.bounds.center.y + box.bounds.extents.y;
        if (Input.GetKey(up) &&
            boxY < mainCamera.orthographicSize)
        {
            transform.position += speed * Time.deltaTime * Vector3.up;
        }
    }

    public void DownMovement()
    {
        float boxY = box.bounds.center.y - box.bounds.extents.y;
        if (Input.GetKey(down) && 
            boxY > -mainCamera.orthographicSize)
        {
            transform.position -= speed * Time.deltaTime * Vector3.up;
        }
    }

}
