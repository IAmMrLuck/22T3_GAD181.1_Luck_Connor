using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace ConaLuk
{

    public class PunchCounter : MonoBehaviour
    {
        [SerializeField] private TMP_Text PunchCounterText;

        [SerializeField] private int punchCounter = 0;

        private void Update()
        { // adds 1 point to counter each time the button is pressed

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                punchCounter++;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                punchCounter++;
            }
            
            PunchCounterText.text = punchCounter.ToString();
        }

        

    }
}
