using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinTurrel : MonoBehaviour
{
    public float DefaultSpeed;
    public float RotateSpeed;
    public float Direction;
    private float wait = 0;

    private void Start()
    {
        RotateSpeed = DefaultSpeed;
    }

    void FixedUpdate()
    {
        float angle = transform.eulerAngles.z;
        if ((int)angle % 90 == 0)
        {
            wait += Time.deltaTime;
            RotateSpeed = 0;
            if (wait > 0.1f)
            {
                if (Direction == 1)
                    Direction = -1;
                else
                    Direction = 1;

                wait = 0;
                RotateSpeed = DefaultSpeed;
            }
        }
        transform.Rotate(0, 0, RotateSpeed * Direction * Time.deltaTime);
    }
}
