
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBack : MonoBehaviour
{

    public void Back()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Back");
    }
}
