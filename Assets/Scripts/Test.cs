using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public Text score;
    public Text highscore;
    public float finalSpareCount;
    public int round=0;
    public RectTransform _instructionPanel;
    int xVal =0;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && round!=5)
        {
            finalSpareCount = finalSpareCount + Random.Range(5f, 10f);
            score.text = "Score " + finalSpareCount;
            round++;
        }
        else if(round==5)
        {
            HighScoreMethod();
        }
    }
    void HighScoreMethod()
    {
        if (finalSpareCount > PlayerPrefs.GetFloat("HighScore", 0f))
        {
            PlayerPrefs.SetFloat("HighScore", finalSpareCount);
            highscore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore");
        }
        else
        {
            highscore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore");
        }
    }
    public void PanelTransitionRight()
    {
        if(xVal!=300)
        {
            xVal = xVal - 100;
             Vector3 pos = new Vector3(xVal, 0, 0);
            _instructionPanel.localPosition = pos;
        }
    }
    public void PanelTransitionLeft()
    {
        if (xVal !=0)
        {
            xVal = xVal + 100;
         Vector3 pos = new Vector3(xVal, 0, 0);
        _instructionPanel.localPosition = pos;
        }
    }
}
