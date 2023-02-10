using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ConaLuk
{


    public class ScoreHandler : MonoBehaviour
    {

        public GameObject redScore;
        public GameObject blueScore;

        private TMP_Text redScoreText;
        private TMP_Text blueScoreText;


        void Start()
        {
            redScoreText = redScore.GetComponent<TMP_Text>();
            blueScoreText = blueScore.GetComponent<TMP_Text>();

            redScoreText.text = PlayerPrefs.GetString("redScore");
            blueScoreText.text = PlayerPrefs.GetString("blueScore");
        }

    }
}
