using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OptionsMenuScript : MonoBehaviour
{
    public int TimeTrialSceneNumber;
    public GameObject LoadScreen;
    public void BeginRace()
    {
        StartCoroutine(WaitToLoad());
        
    }
    IEnumerator WaitToLoad()
    {
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        SaveScript.TimeMinutes = 0;
        SaveScript.TimeSeconds=0;
        SceneManager.LoadScene(TimeTrialSceneNumber);
    }
}
qqq