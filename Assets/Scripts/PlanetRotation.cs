using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed;
    const float rotationSpeedOfEarth = 1574;
    private float relativeSpeed;
    private float rotationSpeedFactor;
    private ModeSelector modeSelector;
   
    void Start()
    {
        modeSelector = FindObjectOfType<ModeSelector>();
        rotationSpeedFactor = FindObjectOfType<SolarStats>().GetRotationSpeedFactor();
        relativeSpeed = rotationSpeed / rotationSpeedOfEarth;
    }

    
    void Update()
    {
        if (modeSelector.CanSimulate())
        {
            transform.Rotate(Vector3.up * relativeSpeed * Time.deltaTime * rotationSpeedFactor);
         }
    }
}
