using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour
{
    [HideInInspector]
    public static int score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Exit()
    {
        Application.Quit();
    }
}
