using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipEnd : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(7);
    }
}
