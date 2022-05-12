using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCommander : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

        public void BackToMainMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void InstructionsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayGameButton()
    {
        SceneManager.LoadScene(6);
    }
}
