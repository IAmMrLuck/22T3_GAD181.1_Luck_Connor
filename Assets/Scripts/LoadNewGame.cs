using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNewGame : MonoBehaviour
{

    public void Rematch()

    {
        SceneManager.LoadScene("Robot Fight");
    }
    
    

}
