using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public static float Timer;
    public static int intTimer;
    int five=0;
    private float intTimerCounter;
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        intTimerCounter += Time.deltaTime;
        if (intTimerCounter >= 1) 
        {
            intTimer++;
            intTimerCounter--;
        }
        
            
    }
}
