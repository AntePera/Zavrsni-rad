using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(SaveScript.TimeMinutes < 4)
        {
            SaveScript.Record = true; 
        }
        else if (SaveScript.TimeMinutes == 4 && SaveScript.TimeSeconds < 45)
        {
            SaveScript.Record = true;
        }
        else
        {
            SaveScript.Record= false;
        }
    }
}
