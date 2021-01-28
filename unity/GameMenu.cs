// A simple script to open and close a menu object when a key is pressed.
// Also includes support for buttons, and allows the user to "disconnect" and "resume", resume closes the menu down and disconnect sends you to a scene.



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{

    [SerializeField] private GameObject gameMenu;
    private bool menuOpen = false;

    public Button disconnectButton;
    public Button resumeButton;

void Start()
    {
        disconnectButton.onClick.AddListener(Disconnect);
        resumeButton.onClick.AddListener(Resume);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuOpen)
        {
            gameMenu.SetActive(true);
            menuOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && menuOpen)
        {
            Resume();
        }
    }

    public void Disconnect()
        {
            SceneManager.LoadScene("Scene_Menu");
        }

    public void Resume()
        {
            gameMenu.SetActive(false);
            menuOpen = false;
        }

}
