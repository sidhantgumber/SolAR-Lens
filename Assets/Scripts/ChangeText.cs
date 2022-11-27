using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI planetText;
    string writer;

    [TextArea(5, 10)]
    public string[] planetTexts;
    public float timeBtwChars = 0.1f;

    private void Start()
    {
        //  planetText.text = planetTexts[0];
        writer = planetTexts[0];
        StartCoroutine(TypeWriterTMP());

    }

    public void NextText()
    {
     
        int i;
        Debug.Log("Button Pressed" + planetTexts.Length);
     
            if (planetText.text == planetTexts[planetTexts.Length - 1])
            {
            writer = planetTexts[0];
            StartCoroutine(TypeWriterTMP());
        }
            else
            {
                Debug.Log("Next Text Loaded");
                for (i =0; i < planetTexts.Length; i++)
                {


                    if (planetText.text == planetTexts[i])
                    {
                   // planetText.text = planetTexts[i + 1];
                    writer = planetTexts[i + 1];
                    StartCoroutine(TypeWriterTMP());
                    
                    
                  //  planetText.GetComponent<TypeWriterEffect>().StartTyping();
                   //  i = 0;
                   // break;
                    }
                }
            }
      //  writer = "";
       // planetText.text = "";

    }
    IEnumerator TypeWriterTMP()
    {
        planetText.text = null;
        foreach (char c in writer)
        {
       
            planetText.text += c;
       
            yield return new WaitForSeconds(timeBtwChars);
        }
   


    }
    
}
