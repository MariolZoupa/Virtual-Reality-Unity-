using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float current_time = 0f;
    float starting_time = 30f;

    [SerializeField] Text countdownText;

    private void Start()
    {
        current_time = starting_time;

    }
    Color orange = new Vector4(255f, 173f, 3f, 1.0f);

    private void Update()
    {
        current_time -= 1 * Time.deltaTime;
        countdownText.text = current_time.ToString("0");

        if (current_time <= 0)
        {
            current_time = 0;
        }


        if (current_time <= 10)
        {
            countdownText.color = Color.red;
        }
    }
    
}
