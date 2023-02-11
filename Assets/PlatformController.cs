using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Fake;
    [SerializeField]
    private List<GameObject> Heroes;
    private int starts = 0;
    [SerializeField]
    private GameObject LeftButton;
    [SerializeField]
    private GameObject RightButton;
    public int numbersHeroes;
    private Animator _animator;


    void Start()
    {
       _animator = GetComponent<Animator>();
        numbersHeroes = 1;
        if (!PlayerPrefs.HasKey("numbersHeroes"))
        {
            PlayerPrefs.SetInt("numbersHeroes", numbersHeroes);
        }
        else
        {
            numbersHeroes=PlayerPrefs.GetInt("numbersHeroes");
        }
        
    }

    void Update()
    {

        if (!PlayerPrefs.HasKey("numbersHeroes"))
        {
            PlayerPrefs.SetInt("numbersHeroes", numbersHeroes);
        }
        else
        {
           numbersHeroes= PlayerPrefs.GetInt("numbersHeroes");
        }

        if (starts == 0)
        {
            starts++;
            StartCoroutine(StartPlatform());
        }
        if (numbersHeroes == 1) { LeftButton.SetActive(false); RightButton.SetActive(true); }
        else if (numbersHeroes == 2)  {   LeftButton.SetActive(true); RightButton.SetActive(true); }
        else if (numbersHeroes == 3) { RightButton.SetActive(false); LeftButton.SetActive(true); }

        _animator.SetInteger("numbersHeroes", numbersHeroes);
    }

    IEnumerator StartPlatform()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < Fake.Count; i++) 
        {
            Fake[i].SetActive(false);
            Heroes[i].SetActive(true);
        }
    }


    public void Right()
    {
        if (numbersHeroes == 1)
        {
            _animator.SetTrigger("NextFirst");
        }
        else if (numbersHeroes == 2)
        {
            _animator.SetTrigger("NextSecond");
        }
        numbersHeroes++;
        PlayerPrefs.SetInt("numbersHeroes", numbersHeroes);
    }

    public void Left()
    {
        if (numbersHeroes == 3)
        {
            _animator.SetTrigger("LastSecond");
        }
        else if (numbersHeroes == 2)
        {
            _animator.SetTrigger("LastFirst");
        }
        numbersHeroes--;
        PlayerPrefs.SetInt("numbersHeroes", numbersHeroes);
        
    }
}
