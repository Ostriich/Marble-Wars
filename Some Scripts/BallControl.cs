using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BallControl : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D rigidbody;

    void Start()
    {
        System.Random rnd = new System.Random();
        rigidbody.velocity = new Vector2(rnd.Next(1,5), rnd.Next(1, 5));
    }

}
