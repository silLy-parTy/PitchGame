using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonStartUI : MonoBehaviour
{
    [SerializeField] private string Game = "pitch Game";

    public void NewGameButton()
    {
        SceneManager.LoadScene(Game);
    }
}
