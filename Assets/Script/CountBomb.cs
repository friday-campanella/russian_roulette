    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountBomb : MonoBehaviour
{

    // 最小値を表示
    public TextMeshProUGUI bombcount;

    //最大値の変更
    public static int Bomb;


    public void Start()
    {
        Bomb = 1;

        UpdateLabel();
    }

    public void OnClickMinus()
    {

        if (Bomb > 1)
        {
            Bomb--;
        }

        UpdateLabel();
    }

    public void OnClickPlus()
    {
        if (Bomb < CountBird.Bird)
        {
            Bomb++;
        }
       

        UpdateLabel();
    }

    void UpdateLabel()
    {
        string BombStr = Bomb.ToString();
        bombcount.text = BombStr;
    }



}

