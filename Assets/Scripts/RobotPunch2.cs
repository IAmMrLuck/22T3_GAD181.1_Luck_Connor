using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ConaLuk
{
    public class RobotPunch2 : MonoBehaviour
    {
        [SerializeField]
        private

        // Update is called once per frame
        void Update()
        {
            // player presses left arrow and the arm rotates
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, -90);
            }

            //when the player lets go of the left arrow, the arm returns to it's starting position
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, 90);
            }

        }
    }
}