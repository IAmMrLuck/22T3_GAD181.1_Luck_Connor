using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace ConaLuk
{

    public class CountdownTimer : MonoBehaviour
    {
        [SerializeField] private float TimeLeft;
        [SerializeField] private bool TimerOn = false;
        [SerializeField] private TMP_Text TimerText;

        void Start()
        {   //turns the timer on at the start of the game 
            TimerOn = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (TimerOn)
            {
                if (TimeLeft > 0)
                {
                    TimeLeft -= Time.deltaTime;
                    updateTimer(TimeLeft); // calls the below method
                }
                else
                {
                    TimeLeft = 0;
                    TimerOn = false;
                }
            }

            if(TimeLeft <= 0)
            {
                SceneManager.LoadScene("End Game");
            }
        }

        void updateTimer(float currentTime)
        {

            currentTime += 1;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

        }

        
    }
}
