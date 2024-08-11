using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        float verticalmove = Input.GetAxisRaw("Vertical");

        Vector2 position = transform.position;

        position.x = position.x + 0.05f * horizontalmove;
        position.y = position.y + 0.05f * verticalmove;

        transform.position = position;
    }
}
