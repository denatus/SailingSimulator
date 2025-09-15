using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeadReckoning : MonoBehaviour
{
    public TMP_Text textField;
    public Button startDeadReckoningButton;
    public Button sendNMEAButton;

    bool deadReckoningStarted = false;
    bool sendingNMEA = false;
    DateTime timeOfSimlationStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ColorBlock cb = startDeadReckoningButton.colors;
        cb.normalColor = Color.red;
        cb.highlightedColor = Color.red;
        cb.pressedColor = Color.red;
        cb.disabledColor = Color.red;
        cb.selectedColor = Color.red;
        startDeadReckoningButton.colors = cb;

        cb = sendNMEAButton.colors;
        cb.normalColor = Color.red;
        cb.highlightedColor = Color.red;
        cb.pressedColor = Color.red;
        cb.disabledColor = Color.red;
        cb.selectedColor = Color.red;
        sendNMEAButton.colors = cb;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now.ToLocalTime();
        string s;
        if (deadReckoningStarted)
        {
            s = "Start time: " + timeOfSimlationStart.ToString() + " \r\n";
        }
        else
        {
            s = "Start time: " + now.ToString() + " \r\n";
        }        
        s += "Current time: " + now.ToString() + " \r\n";
        s += "Latitude: \r\n";
        s += "Longitude: ";
        textField.text = s;
    }

    public void startDeadReckoningButtonPress()
    {
        if (deadReckoningStarted == false)
        {
            ColorBlock cb = startDeadReckoningButton.colors;
            cb.normalColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.pressedColor = Color.green;
            cb.disabledColor = Color.green;
            cb.selectedColor = Color.green;
            startDeadReckoningButton.colors = cb;
            timeOfSimlationStart = DateTime.Now.ToLocalTime();
            deadReckoningStarted = true;
        }
        else
        {
            ColorBlock cb = startDeadReckoningButton.colors;
            cb.normalColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.pressedColor = Color.red;
            cb.disabledColor = Color.red;
            cb.selectedColor = Color.red;
            startDeadReckoningButton.colors = cb;
            deadReckoningStarted = false;
        }

    }

    public void sendNMEAButtonPress()
    {
        if (sendingNMEA == false)
        {
            ColorBlock cb = sendNMEAButton.colors;
            cb.normalColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.pressedColor = Color.green;
            cb.disabledColor = Color.green;
            cb.selectedColor = Color.green;
            sendNMEAButton.colors = cb;
            sendingNMEA = true;
        }
        else
        {
            ColorBlock cb = sendNMEAButton.colors;
            cb.normalColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.pressedColor = Color.red;
            cb.disabledColor = Color.red;
            cb.selectedColor = Color.red;
            sendNMEAButton.colors = cb;
            sendingNMEA = false;
        }
    }
}
