using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUI : MonoBehaviour
{
    public GameObject textImage;

    public void ToggleTextImage()
    {
        if (!textImage.activeInHierarchy)
        {
            textImage.SetActive(true);

        }
        else textImage.SetActive(false);
    }
}