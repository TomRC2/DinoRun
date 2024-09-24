using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    public GameObject Retry;
    public void Retry1()
    {
        SceneManager.LoadScene("DinoScene");
        Time.timeScale = 1.0f;
    }
    
}