using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderMan : MonoBehaviour
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


        fact.text = "In the late 60's it became known that Richard and Mary Parker were actually government agents," +
                   " working for S.H.I.E.L.D. They successfully completed missions around the globe, and once even saved Wolverine's life." +
                   " Richard and Mary died shortly after Peter was born in a plane crash set up by the Red Skull.";

        platformController.SetActive(false);
    }
}
