using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AppManager : MonoBehaviour
{
     Animation W1Anim;
     Animation W2Anim;
     Animation W3Anim;
     Animation W4Anim;

    public GameObject W1AnimObj;
    public GameObject W2AnimObj;
    public GameObject W3AnimObj;
    public GameObject W4AnimObj;

    public GameObject W1;
    public GameObject W2;
    public GameObject W3;
    public GameObject W4;

    public GameObject WatchButtons;

    // Start is called before the first frame update
    void Start()
    {
        W1.SetActive(false);
        W2.SetActive(false);
        W3.SetActive(false);
        W4.SetActive(false);

        W1Anim = W1AnimObj.GetComponent<Animation>();
        W2Anim = W2AnimObj.GetComponent<Animation>();
        W3Anim = W3AnimObj.GetComponent<Animation>();
        W4Anim = W4AnimObj.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Active_W1_obj()
     {
        W1.SetActive(true);
        W2.SetActive(false);
        W3.SetActive(false);
        W4.SetActive(false);
        WatchButtons.SetActive(false);

        W1Anim["W1Animation"].speed = 1;
        W1Anim.Play();
     }

    public void Active_W2_obj()
    {
        W1.SetActive(false);
        W2.SetActive(true);
        W3.SetActive(false);
        W4.SetActive(false);
        WatchButtons.SetActive(false);

        W2Anim["W2Animation"].speed = 1;
        W2Anim.Play();
    }

    public void Active_W3_obj()
    {
        W1.SetActive(false);
        W2.SetActive(false);
        W3.SetActive(true);
        W4.SetActive(false);
        WatchButtons.SetActive(false);

        W3Anim["W3Animation"].speed = 1;
        W3Anim.Play();
    }
    public void Active_W4_obj()
    {
        W1.SetActive(false);
        W2.SetActive(false);
        W3.SetActive(false);
        W4.SetActive(true);
        WatchButtons.SetActive(false);

        W4Anim["W4Animation"].speed = 1;
        W4Anim.Play();
    }

    public void CloseButtons()
    {
        string CloseButton = EventSystem.current.currentSelectedGameObject.name;

        if (CloseButton == "Close1")
        {
            W1Anim["W1Animation"].speed = -1;
            W1Anim["W1Animation"].time = W1Anim["W1Animation"].length;
            W1Anim.Play();


            StartCoroutine("WatchButtonsActive");
   
            

        }
        else if(CloseButton == "Close2")
        {
            W2Anim["W2Animation"].speed = -1;
            W2Anim["W2Animation"].time = W2Anim["W2Animation"].length;
            W2Anim.Play();


            StartCoroutine("WatchButtonsActive");

        }
        else if (CloseButton == "Close3")
        {
            W3Anim["W3Animation"].speed = -1;
            W3Anim["W3Animation"].time = W3Anim["W3Animation"].length;
            W3Anim.Play();

            StartCoroutine("WatchButtonsActive");


        }
        else if(CloseButton == "Close4")
        {
           
                W4Anim["W4Animation"].speed = -1;
                W4Anim["W4Animation"].time = W4Anim["W4Animation"].length;
                W4Anim.Play();


            StartCoroutine("WatchButtonsActive");



        }
    }

    public IEnumerator WatchButtonsActive()
    {
        yield return new WaitForSeconds(1.0f);
            WatchButtons.SetActive(true);

    }






}
