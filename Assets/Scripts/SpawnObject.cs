using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnObject : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    GameObject objectPrefab;
    GameObject spawnedGameObject;
    private ModeSelector modeSelector;
 //   private bool canSpawn = true;

    //bool canSpawn = true;

    public ChoosePlanet choosePlanet;
    void Start()
    {
        modeSelector = GetComponent<ModeSelector>();
    }

    // Update is called once per frame
    void Update()
    {
        SetObjectPrefab();
        if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
            if(hits.Count > 0 && !Vector2Extensions.IsPointOverUIObject(Input.GetTouch(0).position))
            {
                 if(spawnedGameObject == null && modeSelector.IsInPlanetMode() )
                 {
                     SetObjectPrefab();
                     spawnedGameObject = Instantiate(objectPrefab, hits[0].pose.position, hits[0].pose.rotation);
                 }
                 else
                 {
                   
                     Destroy(spawnedGameObject);      
                     SetObjectPrefab();
                     spawnedGameObject = Instantiate(objectPrefab, hits[0].pose.position, hits[0].pose.rotation);                             

                 }
               /*
              if(spawnedGameObject == objectPrefab)
                {
                    canSpawn = false;
                }
                if (spawnedGameObject == null)
                {
                    SetObjectPrefab();
                    spawnedGameObject = Instantiate(objectPrefab, hits[0].pose.position, hits[0].pose.rotation);
                }
               if(spawnedGameObject != null && canSpawn)
                {
                    spawnedGameObject = null 
                }
                    */

            }
        }
        
    }

    public void ClearView()
    {
        Debug.Log("Planet View Destroyed");
        Destroy(spawnedGameObject);
    }
  

    void SetObjectPrefab()
    {
        objectPrefab = choosePlanet.GetPlanetPrefab();
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
