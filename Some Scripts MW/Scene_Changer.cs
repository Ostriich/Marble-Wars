using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Changer : MonoBehaviour
{
    [SerializeField]
    GameObject Play;
    public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
        PlayerPrefs.SetInt("ApgX2A", 0);
        PlayerPrefs.SetInt("ApgX2L", 0);
        PlayerPrefs.SetInt("MoneyA", 0);
        PlayerPrefs.SetInt("MoneyL", 0);
        PlayerPrefs.SetInt("IUpgX2A", 0);
        PlayerPrefs.SetInt("IUpgX2L", 0);
        PlayerPrefs.SetInt("IUpgBallA", 0);
        PlayerPrefs.SetInt("IUpgBallL", 0);
        PlayerPrefs.SetInt("IUpgX3X5A", 0);
        PlayerPrefs.SetInt("IUpgX3X5L", 0);
        PlayerPrefs.SetInt("MnozitelA", 2);
        PlayerPrefs.SetInt("MnozitelL", 2);
        PlayerPrefs.SetInt("ISpeedA", 15);
        PlayerPrefs.SetInt("ISpeedL", 15);
        PlayerPrefs.SetInt("IStrengthA", 0);
        PlayerPrefs.SetInt("IStrengthL", 0);
        PlayerPrefs.SetInt("SA", 0);
        PlayerPrefs.SetInt("SL", 0);
        Play.GetComponent<Button>().enabled = true;
        Play.GetComponent<Image>().color = new Color(1f, 1f, 1f); ;
    }
	public void Exit()
	{
		Application.Quit();
	}
}
