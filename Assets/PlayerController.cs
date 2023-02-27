using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerController : MonoBehaviour
{
    private int x;
    public GameObject bird1;
    public GameObject bird2;
    public GameObject bird3;
    public GameObject bird4;
    public GameObject bird5;
    public GameObject bird6;
    public GameObject bird7;
    public GameObject bird8;
    public GameObject bird9;

    [SerializeField] GameObject OutPanel;
    [SerializeField] GameObject SafePanel;

    // Start is called before the first frame update
    void Start()
    {

        x = CountBird.Bird;
        //xが9の時、０匹の鳥を非アクティブにする
        if (x == 8)
        {
            bird9.SetActive(false);
        }
        else if (x == 7)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
        }
        else if (x == 6)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
            bird7.SetActive(false);
        }
        else if (x == 5)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
            bird7.SetActive(false);
            bird6.SetActive(false);
        }
        else if (x == 4)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
            bird7.SetActive(false);
            bird6.SetActive(false);
            bird5.SetActive(false);
        }
        else if (x == 3)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
            bird7.SetActive(false);
            bird6.SetActive(false);
            bird5.SetActive(false);
            bird4.SetActive(false);
        }
        else if (x == 2)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
            bird7.SetActive(false);
            bird6.SetActive(false);
            bird5.SetActive(false);
            bird4.SetActive(false);
            bird3.SetActive(false);
        }
        else if (x == 1)
        {
            bird9.SetActive(false);
            bird8.SetActive(false);
            bird7.SetActive(false);
            bird6.SetActive(false);
            bird5.SetActive(false);
            bird4.SetActive(false);
            bird3.SetActive(false);
            bird2.SetActive(false);
        }


    }

    public void CallNiwatori1()
    {
        SafePanel.SetActive(true);
        bird1.SetActive(false);
    }
    public void CallNiwatori2()
    {
        SafePanel.SetActive(true);
        bird2.SetActive(false);
    }
    public void CallNiwatori3()
    {
        SafePanel.SetActive(true);
        bird3.SetActive(false);
    }
    public void CallNiwatori4()
    {
        SafePanel.SetActive(true);
        bird4.SetActive(false);
    }
    public void CallNiwatori5()
    {
        SafePanel.SetActive(true);
        bird5.SetActive(false);
    }
    public void CallNiwatori6()
    {
        SafePanel.SetActive(true);
        bird6.SetActive(false);
    }
    public void CallNiwatori7()
    {
        SafePanel.SetActive(true);
        bird7.SetActive(false);
    }
    public void CallNiwatori8()
    {
        SafePanel.SetActive(true);
        bird8.SetActive(false);
    }
    public void CallNiwatori9()
    {
        SafePanel.SetActive(true);
        bird9.SetActive(false);
    }

    public void RmNiwatori()
    {
        SafePanel.SetActive(false);
    }

    public void RmKarage()
    {
        OutPanel.SetActive(false);
    }
}