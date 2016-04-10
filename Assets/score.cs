using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    Text text;
    public int playerscore;
    private int curTime;
    // Use this for initialization
    void Start()
    {
        playerscore = 0;
        curTime = (int)Time.time;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerscore = (int)Time.time * 10 - curTime * 10;
        text.text = "Score: " + playerscore;
    }
}
