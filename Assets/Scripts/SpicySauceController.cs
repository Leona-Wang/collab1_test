using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpicySauceController : MonoBehaviour
{
    double iniTime = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iniTime += Time.deltaTime;

        while (iniTime <= 5)
		{
            this.gameObject.transform.localScale = new Vector3(2f, 2f, 0f);
        }
        this.gameObject.transform.localScale = new Vector3(1f, 1f, 0f);
        iniTime = 0;


    }
}
