using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour
{

    public float speed;
    public Transform maxUp, maxDown;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < maxUp.position.y)
        {
            
            speed = -speed;
        }

        if (transform.position.y > maxDown.position.y)
        {
            speed = -speed;
        }

        this.transform.Translate(0f, 1f * speed, 0f);
    }
}
