using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrimeInProgressUI : MonoBehaviour
{
    public bool startCountdown = false;

    public float crimeInProgressTimer = 10f;
    public Text startText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startCountdown)
        {
            DisplayCrimeCountDownTimer();
        }
    }

    public void DisplayCrimeCountDownTimer()
    {
        crimeInProgressTimer -= Time.deltaTime;
        startText.text = "Criminals leaving in " + (crimeInProgressTimer).ToString() + "S";

    }
}
