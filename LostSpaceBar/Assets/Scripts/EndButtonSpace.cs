using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonSpace : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(4);
    }
}
