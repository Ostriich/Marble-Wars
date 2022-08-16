using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTheme2P : MonoBehaviour
{
    public GameObject Sec1;
    public GameObject Sec2;
    public GameObject Sec3;
    public GameObject Sec4;
    public GameObject Kol1;
    public GameObject Verx1;
    public GameObject Kol2;
    public GameObject Verx2;
    public GameObject CounterUp1;
    public GameObject CounterUp2;
    public GameObject CounterDown1;
    public GameObject CounterDown2;
    public GameObject CounterMoney1;
    public GameObject CounterMoney2;
    public GameObject TimePlant;
    public GameObject TimeMin;
    public GameObject TimeSec1;
    public GameObject TimeSec2;
    public GameObject TimeDots;
    public GameObject LeftCannon;
    public GameObject RightCannon;
    public GameObject LeftPicBul;
    public GameObject RightPicBul;
    public GameObject LeftBallF;
    public GameObject RightBallF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("ColorTheme") == 0)
        {
            Sec1.GetComponent<Image>().sprite = Resources.Load <Sprite>("SectionF1W");
            Sec2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionUpg1W");
            Sec3.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionF(R)1W");
            Sec4.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionUpg(R)1W");

            Kol1.GetComponent<Image>().sprite = Resources.Load<Sprite>("KolW");
            Verx1.GetComponent<Image>().sprite = Resources.Load<Sprite>("VershinaW");
            Kol2.GetComponent<Image>().sprite = Resources.Load<Sprite>("KolW");
            Verx2.GetComponent<Image>().sprite = Resources.Load<Sprite>("VershinaW");

            CounterUp1.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            CounterUp2.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            CounterDown1.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            CounterDown2.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            CounterMoney1.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            CounterMoney2.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            TimePlant.GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            TimeMin.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            TimeSec1.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            TimeSec2.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
            TimeDots.GetComponent<Text>().color = new Color32(50, 50, 50, 255);
        }
        else
        {
            Sec1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionF1");
            Sec2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionUpg1");
            Sec3.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionF(R)1");
            Sec4.GetComponent<Image>().sprite = Resources.Load<Sprite>("SectionUpg(R)1");

            Kol1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Kol");
            Verx1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Vershina");
            Kol2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Kol");
            Verx2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Vershina");

            CounterUp1.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            CounterUp2.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            CounterDown1.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            CounterDown2.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            CounterMoney1.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            CounterMoney2.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            TimePlant.GetComponent<Image>().color = new Color32(0, 0, 0, 120);
            TimeMin.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            TimeSec1.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            TimeSec2.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            TimeDots.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
        }



        if (PlayerPrefs.GetInt("ColorCannon1") == 1)
        {
            LeftCannon.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
            LeftPicBul.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
            LeftBallF.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
            LeftBallF.GetComponent<SpriteRenderer>().color = new Color32(4, 184, 241, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon1") == 2)
        {
            LeftCannon.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
            LeftPicBul.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
            LeftBallF.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
            LeftBallF.GetComponent<SpriteRenderer>().color = new Color32(30, 220, 11, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon1") == 3)
        {
            LeftCannon.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
            LeftPicBul.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
            LeftBallF.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
            LeftBallF.GetComponent<SpriteRenderer>().color = new Color32(255, 253, 0, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon1") == 4)
        {
            LeftCannon.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
            LeftPicBul.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
            LeftBallF.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
            LeftBallF.GetComponent<SpriteRenderer>().color = new Color32(255, 5, 0, 255);
        }


        if (PlayerPrefs.GetInt("ColorCannon2") == 1)
        {
            RightCannon.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
            RightPicBul.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
            RightBallF.GetComponent<Image>().color = new Color32(4, 184, 241, 255);
            RightBallF.GetComponent<SpriteRenderer>().color = new Color32(4, 184, 241, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon2") == 2)
        {
            RightCannon.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
            RightPicBul.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
            RightBallF.GetComponent<Image>().color = new Color32(30, 220, 11, 255);
            RightBallF.GetComponent<SpriteRenderer>().color = new Color32(30, 220, 11, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon2") == 3)
        {
            RightCannon.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
            RightPicBul.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
            RightBallF.GetComponent<Image>().color = new Color32(255, 253, 0, 255);
            RightBallF.GetComponent<SpriteRenderer>().color = new Color32(255, 253, 0, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon2") == 4)
        {
            RightCannon.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
            RightPicBul.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
            RightBallF.GetComponent<Image>().color = new Color32(255, 5, 0, 255);
            RightBallF.GetComponent<SpriteRenderer>().color = new Color32(255, 5, 0, 255);
        }
    }
}
