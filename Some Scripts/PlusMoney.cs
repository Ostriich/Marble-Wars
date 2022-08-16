using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusMoney : MonoBehaviour
{
    public int ball;
    void Update()
    {
        if (ball==1)
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("MoneyA").ToString()+"$";
        if (ball==2)
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("MoneyL").ToString() + "$";
    }
}
