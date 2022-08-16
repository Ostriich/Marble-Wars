using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class TurrelTriggerBullet : MonoBehaviour
{
    [SerializeField] private bool _testMode = false;
    private string _gameId = "4481857";
    private string _video = "Interstitial_Android";

    public int ball;
    public GameObject pause;
    public GameObject Play;
    public GameObject Text;
    public GameObject Camera;
    public GameObject Audio;
    public AudioClip AudioClip;
    public int form;
    void Start()
    {
        Advertisement.Initialize(_gameId, _testMode);
    }
    public static void ShowsAdsVideo (string placementId)
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show(placementId);
        }
        else
        {
            Debug.Log("Advertisement not ready");
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (ball==1)
            if (col.gameObject.CompareTag("BulletGreen"))
            {
                pause.SetActive(true);
                Time.timeScale = 0;
                Play.GetComponent<Button>().enabled = false;
                Play.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
                Camera.GetComponent<AudioSource>().Pause();
                if (PlayerPrefs.GetInt("Sound") == 0)
                    Audio.GetComponent<AudioSource>().PlayOneShot(AudioClip);
                if (form==2)
                    Text.GetComponent<Text>().text = "Green Winner";
                else
                    Text.GetComponent<Text>().text = "You Lose";
                Text.GetComponent<Text>().color= new Color(0.1f, 1f, 0.1f);
                ShowsAdsVideo("Interstitial_Android");
            }
        if (ball==2)
            if (col.gameObject.CompareTag("BulletAqua"))
            {
                pause.SetActive(true);
                Time.timeScale = 0;
                Play.GetComponent<Button>().enabled = false;
                Play.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
                Camera.GetComponent<AudioSource>().Pause();
                if (PlayerPrefs.GetInt("Sound") == 0)
                    Audio.GetComponent<AudioSource>().PlayOneShot(AudioClip);
                if (form == 2)
                    Text.GetComponent<Text>().text = "Blue Winner";
                else
                    Text.GetComponent<Text>().text = "You Win";
                Text.GetComponent<Text>().color = new Color(0.1f, 0.8f, 1f);
                ShowsAdsVideo("Interstitial_Android");
            }
    }


}
