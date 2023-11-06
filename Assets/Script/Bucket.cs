using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bucket : MonoBehaviour
{
    private GameObject ScoreText;
    ScoreManager scoremanager;
    private float Timer;
    private Slider UnPackTimer;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.Find("ScoreManager");
        scoremanager = ScoreText.GetComponent<ScoreManager>();
        UnPackTimer = GameObject.Find("UnPackTimer").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        UnPackTimer.value = Timer;
    }

    public void UnPacking()
    {
        
        if (this.transform.childCount > 0)
        {
            Timer += Time.deltaTime;
            if(Timer > 10)
            {
                Debug.Log("10ïbóßÇ¡ÇΩÇÊÅI");
                scoremanager.AddScore(1);
                Destroy(this.transform.GetChild(0).gameObject);
                Timer = 0;
            }
        }
    }
}
