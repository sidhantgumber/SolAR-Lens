using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusRotation : MonoBehaviour
{
    const float rotationSpeed = 14794;
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
            transform.Rotate(Vector3.right * relativeSpeed * Time.deltaTime * rotationSpeedFactor);
        }
    }
}
