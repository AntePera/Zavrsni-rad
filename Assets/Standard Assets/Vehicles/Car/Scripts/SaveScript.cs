using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityStandardAssets.Vehicles.Car;

public class SaveScript : MonoBehaviour
{
    public static float Speed;
    public static float TopSpeed;
    public static int Gear;
    public static bool RunFinish;
    public static float TimeMinutes;
    public static float TimeSeconds;
    public static bool RaceStart=false;
    public static bool RaceOver = false;
    public static bool Record = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RaceOver == false)
        { 
            TimeSeconds = TimeSeconds + 1 * Time.deltaTime;
            if(TimeSeconds>59)
            {
                TimeSeconds = 0f;
                TimeMinutes++;   
            }
        }
    }
}
