using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class timer : MonoBehaviour
{

    public Text timerText;
    public float time;
    public Flowchart fc;

    private void Start()
    {
        time = fc.GetFloatVariable("TimeAmount");
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        if(time <= 0)
        {
            fc.SetBooleanVariable("TimeOut", true);
        }
        timerText.text = time.ToString();
    }
}
