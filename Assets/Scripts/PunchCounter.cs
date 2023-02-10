using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace ConaLuk
{

    public class PunchCounter : MonoBehaviour
    {
        [SerializeField] private TMP_Text redCounterText;
        [SerializeField] private TMP_Text blueCounterText;

        [SerializeField] private int redCounter = 0;
        [SerializeField] private int blueCounter = 0;

        private void Update()
        { // adds 1 point to counter each time the button is pressed

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                redCounter++;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                redCounter++;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                blueCounter++;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                blueCounter++;
            }

            redCounterText.text = redCounter.ToString();
            blueCounterText.text = blueCounter.ToString();


            PlayerPrefs.SetString("redScore", redCounterText.text);
            PlayerPrefs.SetString("blueScore", blueCounterText.text);
        }

        

    }
}
