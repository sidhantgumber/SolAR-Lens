using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCanvas : MonoBehaviour
{
    public GameObject MenuButtons;
    public GameObject InstructionsPanel;

    public void InstructionsButton()
    {
        MenuButtons.SetActive(false);
        InstructionsPanel.SetActive(true);
    }
    public void BackButton()
    {
        MenuButtons.SetActive(true);
        InstructionsPanel.SetActive(false);
    }
}
