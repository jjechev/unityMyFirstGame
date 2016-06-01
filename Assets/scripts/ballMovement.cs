using UnityEngine;
using System.Collections;

public class ballMovement : MonoBehaviour
{

    public float speedX;
    public float speedY;
    private AudioSource sound;

    // Use this for initialization
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(1f * speedX, 1f * speedY, 0f);


    }

    public void OnTriggerEnter(Collider col)
    {

        if (col.tag == "upOrDown")
        {
            ChangeDirection(col);
        }

        if (col.tag == "leftOrRight")
        {

            if (speedX > 0 && col.name == "wall right")
            {
                gameManager.score += 100;
            }
            if (speedX < 0 && col.name == "wall left (exit)")
            {
                gameManager.score -= 200;
            }

            ChangeDirection(col);
        }

        
    }

    public void ChangeDirection(Collider col)
    {
        sound.Play();

        if (col.name == "player")
        {
            //           if(this.transform.position.y > col.transform.position.y + 0.2f)
            //           {
            //                 speedY *= 2;
            //            }

            speedY = -((col.transform.position.y - this.transform.position.y) / col.transform.localScale.y / 5);
            Debug.Log(speedY);


        }

        if (col.tag == "upOrDown")
        {
            speedY = -speedY;
        }
        if (col.tag == "leftOrRight")
        {
            speedX = -speedX;
        }


    }

}
