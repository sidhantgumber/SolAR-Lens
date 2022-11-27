using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelector : MonoBehaviour
{
    private SpawnObject planetView;
    private SpawnSolarSystem solarView;
    private bool isInSolarMode = false;
    private bool isInPlanetMode = true;
    public bool simulate = false;
    void Start()
    {
        planetView = GetComponent<SpawnObject>();
        solarView = GetComponent<SpawnSolarSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivatePlanetView()
    {
        isInPlanetMode = true;
        isInSolarMode = false;
        if (planetView.enabled == true) return;
        Debug.Log("Planet View Active");
        solarView.ClearView();
        solarView.enabled = false;
        planetView.enabled = true;
        
      //  GetComponent<SpawnSolarSystem>().enabled = false;
    }
    public void ActivateSolarView()
    {
        isInSolarMode = true;
        isInPlanetMode = false;
        if (solarView.enabled == true) return;
        Debug.Log("Solar View Active");
        planetView.ClearView();
        planetView.enabled = false;
        solarView.enabled = true;

       //GetComponent<SpawnObject>().enabled = false;

    }
    public bool IsInSolarMode()
    {
        return isInSolarMode;
    }
    public bool IsInPlanetMode()
    {
        return isInPlanetMode;
    }

    public void ToggleSimulation()
    {
        if (!simulate)
        {
            simulate = true;
        }
        else simulate = false;
    }

    public bool CanSimulate()
    {
        return simulate;
    }
   


}
