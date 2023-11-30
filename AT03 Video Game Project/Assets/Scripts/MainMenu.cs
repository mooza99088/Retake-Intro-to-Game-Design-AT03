using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Awake is called before start.
    /// </summary>
    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    /// <summary>
    /// Loads the first level of the game.
    /// </summary>
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// quits game to desktop.
    /// </summary>
    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
