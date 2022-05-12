using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathplane2 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(3);
    }
}
