using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text ScoreText;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.SetText("{0}", Score);
    }

    public void AddScore(int addscore)
    {
        Debug.Log("�Ă΂ꂽ");
        Score += addscore;
    }
}
