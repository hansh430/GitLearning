using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadingBar : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] Text timerTxt;
    [SerializeField] Image fill;
    [SerializeField] float Max;
    void Update()
    {
        time -= Time.deltaTime;
        timerTxt.text = "" + (int)time;
        fill.fillAmount = time / Max;
        if (time < 0)
            time = 0;
    }
}
