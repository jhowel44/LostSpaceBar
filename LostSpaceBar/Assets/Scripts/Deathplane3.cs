using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathplane3 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(6);
    }
}
