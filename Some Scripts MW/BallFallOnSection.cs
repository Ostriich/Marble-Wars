using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallFallOnSection : MonoBehaviour
{
    public int ball;
    public GameObject BallsPlus;
    public GameObject GoShot;

    private void OnCollisionEnter2D(Collision2D col)
    {
        
            if (col.gameObject.CompareTag("X2"))
            {
                
                if (ball == 1)
            {
                gameObject.transform.position = new Vector3(Random.Range(-8f, -5.1f), 4f, -0.01f);
                BallsPlus.GetComponent<Text>().text = (int.Parse(BallsPlus.GetComponent<Text>().text) * PlayerPrefs.GetInt("MnozitelA")).ToString();
            }
                if (ball == 2)
            {
                BallsPlus.GetComponent<Text>().text = (int.Parse(BallsPlus.GetComponent<Text>().text) * PlayerPrefs.GetInt("MnozitelL")).ToString();
                gameObject.transform.position = new Vector3(Random.Range(5.1f, 8f), 4f, -0.01f);
            }
                
            }
            if (col.gameObject.CompareTag("Shot"))
            {
                GoShot.GetComponent<Text>().text = (int.Parse(GoShot.GetComponent<Text>().text)+int.Parse(BallsPlus.GetComponent<Text>().text)).ToString();
                BallsPlus.GetComponent<Text>().text = "1";
                if (ball==1)
                gameObject.transform.position = new Vector3(Random.Range(-8f, -5.1f), 4f, -0.01f);
                if (ball == 2)
                gameObject.transform.position = new Vector3(Random.Range(5.1f, 8f), 4f, -0.01f);
        }


    }
}
