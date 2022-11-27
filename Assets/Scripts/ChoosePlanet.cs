using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlanet : MonoBehaviour
{
    public GameObject sunPrefab;
    public GameObject mercuryPrefab;
    public GameObject venusPrefab;
    public GameObject earthPrefab;
    public GameObject marsPrefab;
    public GameObject jupiterPrefab;
    public GameObject saturnPrefab;
    public GameObject uranusPrefab;
    public GameObject neptunePrefab;
    public GameObject plutoPrefab;

    GameObject selectedPlanet;

    public void SetSun()
    {
        selectedPlanet = sunPrefab;
    }
    public void SetMercury()
    {
        selectedPlanet = mercuryPrefab;
    }
    public void SetVenus()
    {
        selectedPlanet = venusPrefab;
    }
    public void SetEarth()
    {
        selectedPlanet = earthPrefab;
    }
    public void SetMars()
    {
        selectedPlanet = marsPrefab;
    }
    public void SetJupiter()
    {
        selectedPlanet = jupiterPrefab;
    }
    public void SetSaturn()
    {
        selectedPlanet = saturnPrefab;
    }
    public void SetUranus()
    {
        selectedPlanet = uranusPrefab;
    }
    public void SetNeptune()
    {
        selectedPlanet = neptunePrefab;
    }
    public void SetPluto()
    {
        selectedPlanet = plutoPrefab;
    }

    public GameObject GetPlanetPrefab()
    {
        return selectedPlanet;
    }
}
