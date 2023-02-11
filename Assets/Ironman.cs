using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ironman : MonoBehaviour
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


        fact.text = "Spider-Man is one of the most popular comic book characters." +
                   " Long before Robert Downey Jr donned the Iron Man armor," +
                   " It was Spider-Man who was the face of Marvel. The sixth film about Spidey and the first solo film" +
                   " within the Marvel Cinematic Universe is rightfully considered one of the" +
                   " the most anticipated films of 2017.";
        platformController.SetActive(false);
    }


}
