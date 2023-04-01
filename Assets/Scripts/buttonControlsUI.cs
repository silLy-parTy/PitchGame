using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControlsUI : MonoBehaviour
{
    [SerializeField] private string Controls = "Controls";

    public void NewGameButton()
    {
        SceneManager.LoadScene(Controls);
    }
}