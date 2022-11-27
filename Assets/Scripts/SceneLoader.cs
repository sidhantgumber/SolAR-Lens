using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadStartScene()
    {
        SceneManager.LoadScene(1);

    }
    public void LoadARScene()
    {
        SceneManager.LoadScene(2);

    }

}
