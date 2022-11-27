using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnSolarSystem : MonoBehaviour
{
    private ARPlaneManager arPlaneManager;
    private List<ARPlane> arPlanes;
    private ARPlane idealPlane;
    private GameObject solarSystem;
    public GameObject solarSystemPrefab;
    public float minPlaneLength = 0.3f;
    public float minPlaneWidth = 0.3f;
    private ModeSelector modeSelector;
    // private bool canSpawn = false;

    private void Start()
    {
        modeSelector = GetComponent<ModeSelector>();
    }
    private void OnEnable()
    {
        arPlanes = new List<ARPlane>();
        arPlaneManager = FindObjectOfType<ARPlaneManager>();
        arPlaneManager.planesChanged += OnPlanesChanged;  // yeh event subscribe hoga jab bhi planes change honge
    }
  
    private void OnPlanesChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null && args.added.Count > 0)  // check to confirm that planes are added
        {
            arPlanes.AddRange(args.added);      // add all the planes that have been added to the list, addrange is used to append the planes at the end
        }
        foreach(ARPlane plane in arPlanes)
        {
            if(plane.extents.x > minPlaneLength && plane.extents.y >minPlaneWidth)
            {
                idealPlane = plane;
                break;
            }
        }
        Spawn();
    }
    private void Spawn()
    {
        if (solarSystem == null && modeSelector.IsInSolarMode())
        {
            Debug.Log("Solar System Spawned");
            solarSystem = Instantiate(solarSystemPrefab, idealPlane.transform.position, Quaternion.identity);
        }
    }
    public void ClearView()
    {
        Debug.Log("Solar System Destroyed");
        Destroy(solarSystem);
    }
  /*  public void ToggleCanSpawn()
    {
        if (!canSpawn)
        {
            canSpawn = true;
        }
        else canSpawn = false;
    }
  */
}
