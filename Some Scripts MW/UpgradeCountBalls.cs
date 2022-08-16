using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCountBalls : MonoBehaviour
{
    public int ball;
    int[] mas = new int[4];
    public GameObject TextNext;


    void Update()
    {
        mas[0] = 60;
        mas[1] = 125;
        mas[2] = 200;
        mas[3] = 0;

        if (ball == 1)
        {
            if (PlayerPrefs.GetInt("IUpgBallA") > 2)
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("Deleted1");
                GetComponent<Button>().enabled = false;
                TextNext.GetComponent<Text>().text = "";
            }

            else if (PlayerPrefs.GetInt("MoneyA") < mas[PlayerPrefs.GetInt("IUpgBallA")])
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("UnEnabled1");
                GetComponent<Button>().enabled = false;
            }
            else if (PlayerPrefs.GetInt("MoneyA") >= mas[PlayerPrefs.GetInt("IUpgBallA")])
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("Enabled1");
                GetComponent<Button>().enabled = true;
            }
        }
        if (ball == 2)
        {
            if (PlayerPrefs.GetInt("IUpgBallL") > 2)
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("Deleted");
                GetComponent<Button>().enabled = false;
                TextNext.GetComponent<Text>().text = "";
            }
            else if (PlayerPrefs.GetInt("MoneyL") < mas[PlayerPrefs.GetInt("IUpgBallL")])
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("UnEnabled1");
                GetComponent<Button>().enabled = false;
            }
            else if (PlayerPrefs.GetInt("MoneyL") >= mas[PlayerPrefs.GetInt("IUpgBallL")])
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("Enabled1");
                GetComponent<Button>().enabled = true;
            }
        }
    }

    public void Upgrade()
    {
        if (ball == 1)
        {
            PlayerPrefs.SetInt("MoneyA", PlayerPrefs.GetInt("MoneyA") - mas[PlayerPrefs.GetInt("IUpgBallA")]);
            PlayerPrefs.SetInt("IUpgBallA", PlayerPrefs.GetInt("IUpgBallA") + 1);
            TextNext.GetComponent<Text>().text = "+ 1 Ball" + Environment.NewLine + mas[PlayerPrefs.GetInt("IUpgBallA")].ToString() + "$";
        }
        if (ball == 2)
        {
            PlayerPrefs.SetInt("MoneyL", PlayerPrefs.GetInt("MoneyL") - mas[PlayerPrefs.GetInt("IUpgBallL")]);
            PlayerPrefs.SetInt("IUpgBallL", PlayerPrefs.GetInt("IUpgBallL") + 1);
            TextNext.GetComponent<Text>().text = "+ 1 Ball" + Environment.NewLine + mas[PlayerPrefs.GetInt("IUpgBallL")].ToString() + "$";
        }
    }
}
