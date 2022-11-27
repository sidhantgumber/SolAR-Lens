using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/* Taking the speed of mercury as reference : 47.9km/sec
 * Speed of venus : 1/47.9 * 5.4
 * The algorithm below moves the planets at a speed relative to mercury
 * 
 * 
 * 
 * 
 * 
 * 
 */
public class PlanetRevolution : MonoBehaviour
{
    const float speedOfMercury = 47.9f;
    public float revolutionSpeed = 20f;
    private float relativeSpeed;
    private float revolutionSpeedFactor;
    private ModeSelector modeSelector;
  //  private bool simulate = false;
    GameObject sun;
    void Start()
    {
        modeSelector = FindObjectOfType<ModeSelector>();
        revolutionSpeedFactor = FindObjectOfType<SolarStats>().GetRevolutionSpeedFactor();
        sun = GameObject.FindGameObjectWithTag("Sun");
        relativeSpeed = revolutionSpeed / speedOfMercury;  //  Representing the speed of the planet as a factor of mercury's speed
    }

    // Update is called once per frame
    void Update()
    {
       
       if (modeSelector.CanSimulate())
       {
            transform.RotateAround(sun.transform.position, Vector3.up, relativeSpeed * Time.deltaTime * revolutionSpeedFactor);

       }
    }

    
     
    
}
