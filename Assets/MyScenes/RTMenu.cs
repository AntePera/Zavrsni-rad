using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TrackOptions;

    public void OptionsOn()
    {
        TrackOptions.SetActive(true);
    }
    public void OptionsOff()
    {
        TrackOptions.SetActive(false);
    }
}
