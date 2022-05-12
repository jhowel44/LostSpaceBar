using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathplane1 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(2);
    }
}
