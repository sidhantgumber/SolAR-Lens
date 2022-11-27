using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
    public GameObject planetScroller;

    public void ToggleScroller()
    {
        if (!planetScroller.activeInHierarchy)
        {
            planetScroller.SetActive(true);
        }
        else planetScroller.SetActive(false);
    }
}
