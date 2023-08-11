using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public Text SpeedText;
    private float DisplaySpeed;
    public Text GearText;
    public Text TimeMinutesText;
    public Text TimeSecondsText;
    public Text GoText;
    private float displayDuration = 1f;
    private float startTime;
    public Text RecordMessage;
    public GameObject TimeTrialResult;
    public GameObject FinishLine;
    public GameObject QuitPanel;
    // Start is called before the first frame update
    void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        GoText.enabled = false;
        TimeTrialResult.SetActive(false);
        FinishLine.SetActive(true);
        QuitPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        float elapsedTime = Time.time - startTime;
        if (elapsedTime < displayDuration)
        {
            // Show the text
            GoText.enabled = true;
        }
        else
        {
            // Hide the text after the display duration
            GoText.enabled = false;
            SaveScript.RaceStart = true;
        }
        
        // Speedometer
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString());
        GearText.text=(SaveScript.Gear + 1).ToString();


        //Minutes
        if (SaveScript.TimeMinutes <= 9)
        {
            TimeMinutesText.text= "0" + (Mathf.Round(SaveScript.TimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.TimeMinutes >=10)
        {
            TimeMinutesText.text = (Mathf.Round(SaveScript.TimeMinutes).ToString()) + ":";
        }

        //Seconds
        if (SaveScript.TimeSeconds <= 9)
        {
            TimeSecondsText.text = "0" + (Mathf.Round(SaveScript.TimeSeconds).ToString());
        }
        else if (SaveScript.TimeSeconds >= 10)
        {
            TimeSecondsText.text = (Mathf.Round(SaveScript.TimeSeconds).ToString());
        }


        if (SaveScript.RaceOver == true)
        {
            TimeTrialResult.SetActive(true);
            if (SaveScript.Record == true)
            {
                RecordMessage.text = "Congratulations, new track record";
            }
            else if (SaveScript.Record == false)
            {
                RecordMessage.text = "Try again";
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPanel.SetActive(true);
        }
    }
    public void OnContinue()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitClose()
    {
        QuitPanel.SetActive(false);
    }
}
