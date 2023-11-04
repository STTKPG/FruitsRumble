using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject Camera;
    private GameObject ScoreText;
    MainCam maincam;
    ScoreManager scoremanager;
    private bool IsExit;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("MainCamera");
        ScoreText = GameObject.Find("ScoreManager");
        IsExit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            maincam = Camera.GetComponent<MainCam>();
            scoremanager = ScoreText.GetComponent<ScoreManager>();
        }
        if (maincam != null)
        {
            var MovePosition = new Vector3(Mathf.Clamp(maincam.TargetPosition.x, -5.0f, 5.0f), maincam.TargetPosition.y, Mathf.Clamp(maincam.TargetPosition.z, -5.0f, 5.0f));
            this.transform.position = Vector3.MoveTowards(transform.position, MovePosition, 10 * Time.deltaTime);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Belt")
        {
            if (this.transform.childCount != 0)
            {
                if(IsExit == false)
                {
                    scoremanager.AddScore(1);
                    Destroy(this.transform.GetChild(0).gameObject);
                    IsExit = true;
                }
            }
            Debug.Log("Hit");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Belt")
        {
            IsExit = false;
        }
    }
}
