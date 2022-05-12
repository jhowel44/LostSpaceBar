using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonD : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(5);
    }
}
