using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text timeText;
    public bool playing;
    private float Timer;
    public bool isImageOn;
    public bool isScaredTextOn;
    public Image scaredImg;
    public Text scaredTimeText;
    // Start is called before the first frame update
    void Start()
    {
        scaredImg.enabled = false;
        scaredTimeText.enabled = false;
    }


// Update is called once per frame
    void Update()
    {

        if (playing == true)
        {

            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
            timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }

    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}