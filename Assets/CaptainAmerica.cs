using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptainAmerica : MonoBehaviour
{
    [SerializeField]
    private Text fact; 
    [SerializeField]
    private GameObject panelFact;
    [SerializeField]
    private GameObject platformController;
    private void OnMouseDown()
    {
        panelFact.SetActive(true);

        fact.text = "Michael Jackson was chosen as a fan of Spider-Man and wanted to try on the image of Spidey in the film." +
                   " He approached Stan Lee several times about buying the film rights." +
                   " When that approach didn't work, Michael Jackson decided to just buy the entire Marvel company." +
                   " However, the parties did not agree on the financial issue." +
                   " The asking price of $1 billion has thwarted Michael's movie dream.";

        platformController.SetActive(false);
    }


   
}
