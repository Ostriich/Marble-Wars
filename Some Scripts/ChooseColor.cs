using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseColor : MonoBehaviour
{
    public GameObject Cannon;
    public int CannonNum;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject[] arr;
    public GameObject BackGround;


    void Start()
    {
        arr = new GameObject[4];
        arr[0] = P1;
        arr[1] = P2;
        arr[2] = P3;
        arr[3] = P4;
        if (PlayerPrefs.GetInt("ColorCannon1") == 0)
            PlayerPrefs.SetInt("ColorCannon1", 1);
        if (PlayerPrefs.GetInt("ColorCannon2") == 0)
            PlayerPrefs.SetInt("ColorCannon2", 2);
    }

    public void Click(int color)
    {
        if (CannonNum==1)
            PlayerPrefs.SetInt("ColorCannon1", color);
        else
            PlayerPrefs.SetInt("ColorCannon2", color);
    }
    void Update()
    {

        if (CannonNum == 1)
        {
            for (int i=0; i<4; i++)
            {
                if (PlayerPrefs.GetInt("ColorCannon1")==i+1)
                {
                    arr[i].GetComponent<RectTransform>().sizeDelta = new Vector2(60, 60);
                    if (i==0)
                        Cannon.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
                    if (i == 1)
                        Cannon.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
                    if (i == 2)
                        Cannon.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
                    if (i == 3)
                        Cannon.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
                }
                else
                    arr[i].GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
                if (PlayerPrefs.GetInt("ColorCannon2") == i+1)
                {
                    arr[i].GetComponent<Button>().enabled = false;
                    if (i == 0)
                    {
                        arr[0].GetComponent<Image>().color = new Color32(4, 184, 241, 155);

                    }
                    else
                    {
                        arr[0].GetComponent<Image>().color = new Color32(4, 184, 241, 255);
                    }


                    if (i == 1)
                    {
                        arr[1].GetComponent<Image>().color = new Color32(30, 220, 11, 155);

                    }
                    else
                    {
                        arr[1].GetComponent<Image>().color = new Color32(30, 220, 11, 255);

                    }


                    if (i == 2)
                    {
                        arr[2].GetComponent<Image>().color = new Color32(255, 253, 0, 155);

                    }
                    else
                    {
                        arr[2].GetComponent<Image>().color = new Color32(255, 253, 0, 255);
                    }


                    if (i == 3)
                    {
                        arr[3].GetComponent<Image>().color = new Color32(255, 5, 0, 155);

                    }
                    else
                    {
                        arr[3].GetComponent<Image>().color = new Color32(255, 5, 0, 255);
                    }

                }
                else
                    arr[i].GetComponent<Button>().enabled=true;

            }




        }



        if (CannonNum == 2)
        {
            for (int i = 0; i < 4; i++)
            {
                if (PlayerPrefs.GetInt("ColorCannon2") == i + 1)
                {
                    arr[i].GetComponent<RectTransform>().sizeDelta = new Vector2(60, 60);
                    if (i == 0)
                        Cannon.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
                    if (i == 1)
                        Cannon.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
                    if (i == 2)
                        Cannon.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
                    if (i == 3)
                        Cannon.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
                }
                else
                    arr[i].GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
                if (PlayerPrefs.GetInt("ColorCannon1") == i + 1)
                {
                    arr[i].GetComponent<Button>().enabled = false;
                    if (i == 0)
                    {
                        arr[0].GetComponent<Image>().color = new Color32(4, 184, 241, 155);

                    }
                    else
                    {
                        arr[0].GetComponent<Image>().color = new Color32(4, 184, 241, 255);
                    }


                    if (i == 1)
                    {
                        arr[1].GetComponent<Image>().color = new Color32(30, 220, 11, 155);

                    }
                    else
                    {
                        arr[1].GetComponent<Image>().color = new Color32(30, 220, 11, 255);

                    }


                    if (i == 2)
                    {
                        arr[2].GetComponent<Image>().color = new Color32(255, 253, 0, 155);

                    }
                    else
                    {
                        arr[2].GetComponent<Image>().color = new Color32(255, 253, 0, 255);
                    }


                    if (i == 3)
                    {
                        arr[3].GetComponent<Image>().color = new Color32(255, 5, 0, 155);

                    }
                    else
                    {
                        arr[3].GetComponent<Image>().color = new Color32(255, 5, 0, 255);
                    }

                }
                else
                    arr[i].GetComponent<Button>().enabled = true;

            }




        }




    }
}
