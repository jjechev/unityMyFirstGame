using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    public float speed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Vertical");
        this.transform.Translate(0f, moveY * speed, 0f);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            
                transform.Translate(0f, touchDeltaPosition.y * 0.05f, 0f);
            
        }

    }
}
