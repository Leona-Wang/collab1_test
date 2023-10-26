using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public int iniTime=60;

    double currTime;

    int intTime;

    Text timer;
    // Start is called before the first frame update
    void Start()
    {
        currTime = iniTime;
        timer = this.GetComponent<Text>();
        timer.text = "01:00";
    }

    public int getIntTime()
	{
        return intTime;
	}


    // Update is called once per frame
    void Update()
    {
        
        currTime -= Time.deltaTime;
        intTime = (int)currTime;

        if (intTime < 10 && intTime>0)
		{
            timer.text = "00:0" + intTime.ToString();
        }
        else if (intTime <= 0)
		{
            timer.text = "00:00" ;
        }
		else
		{
            timer.text = "00:" + intTime.ToString();
        }
       
        
    }
}
