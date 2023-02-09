using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ConaLuk
{

    public class PunchDetection : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Punched");
        }
    }
}