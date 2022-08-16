using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletAquaPrefab : MonoBehaviour
{
    int checker = 0;
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        if (PlayerPrefs.GetInt("ColorCannon1") == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(4, 184, 241, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon1") == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(30, 220, 11, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon1") == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 253, 0, 255);
        }
        if (PlayerPrefs.GetInt("ColorCannon1") == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 5, 0, 255);
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("block0")|| col.gameObject.CompareTag("BlockL"))
        {
            checker = checker + 1;
            if (PlayerPrefs.GetInt("ColorCannon1") == 1)
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = new Color32(4, 184, 241, 255);
            }
            if (PlayerPrefs.GetInt("ColorCannon1") == 2)
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = new Color32(30, 220, 11, 255);
            }
            if (PlayerPrefs.GetInt("ColorCannon1") == 3)
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 253, 0, 255);
            }
            if (PlayerPrefs.GetInt("ColorCannon1") == 4)
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 5, 0, 255);
            }
            col.gameObject.layer = 10;
            col.gameObject.tag = "BlockA";
            PlayerPrefs.SetInt("MoneyA", PlayerPrefs.GetInt("MoneyA")+1);
            if (checker> PlayerPrefs.GetInt("SA"))
                Destroy(gameObject);

        }

    }
}
