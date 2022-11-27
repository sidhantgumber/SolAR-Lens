using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject modes;
    public GameObject planetView;
    public GameObject solarView;
 //   private SpawnSolarSystem spawnSolarSystem;
  //  public GameObject solarViewButton;
 //   public ModeSelector modeSelector;
    private void Start()
    {
       // spawnSolarSystem = FindObjectOfType<SpawnSolarSystem>();
    }
    public void ModeButton()
    {
        if (planetView.activeInHierarchy)
        {
            planetView.SetActive(false);
        }
        if(solarView.activeInHierarchy)
        {
            solarView.SetActive(false);
        }
       
        if (!modes.activeInHierarchy)
        {
            modes.SetActive(true);
        }
        else modes.SetActive(false);
    }

    public void PlanetViewButton()
    {
        modes.SetActive(false);
        if (!planetView.activeInHierarchy)
        {
            planetView.SetActive(true);
        }
        else planetView.SetActive(false);
        

    }

    public void SolarViewButton()
    {
        modes.SetActive(false);
        planetView.SetActive(false);
        solarView.SetActive(true);
       
    }
  
     
}
