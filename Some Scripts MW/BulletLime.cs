using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletLime : MonoBehaviour
{
    public Transform shotpos;
    public GameObject Bullet;
    public Text BulletText;
    public AudioClip soundShot;
    private float wait = 0;
    void Start()
    {
        wait = 0;
    }

    void Update()
    {
        if (BulletText.text != "0")
        {
            wait += Time.deltaTime;
            if (wait * 50 > PlayerPrefs.GetInt("ISpeedL"))
            {
                wait = 0;
                Instantiate(Bullet, shotpos.transform.position, transform.rotation);
                if (PlayerPrefs.GetInt("Sound") == 0)
                    GetComponent<AudioSource>().PlayOneShot(soundShot);
                BulletText.text = (int.Parse(BulletText.text) - 1).ToString();
            }
        }

    }
}
