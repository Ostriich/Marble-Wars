using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateFBall : MonoBehaviour
{
    public int ball;
    public GameObject Ball;
    public GameObject NewBall;

    public void Starting()
    {
        if (ball==1)
        {
            NewBall = Instantiate(Ball);
            NewBall.transform.position = new Vector3(Random.Range(-8f, -5.1f), 4f, -0.1f);
            NewBall.transform.localScale = new Vector3(0.625f, 0.625f);
        }
        if (ball == 2)
        {
            NewBall = Instantiate(Ball);
            NewBall.transform.position = new Vector3(Random.Range(5.1f, 8f), 4f, -0.1f);
            NewBall.transform.localScale = new Vector3(0.625f, 0.625f);
        }

    }

    //(Ball, new Vector3(Random.Range(-8f, -5.1f), 4f), transform.rotation);
}
