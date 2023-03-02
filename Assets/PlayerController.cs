using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Button[] buttons;
    public int bombCount;
    public GameObject gameOverPanel;
    private List<int> bombIndexList;
    public GameObject OutPanel;
    public GameObject SafePanel;

    void Start()
    {
        bombIndexList = new List<int>();
        SetButtonEvents();
        SetBombs();
    }
    // 爆弾をランダムに設置する
    void SetBombs()
    {
        int buttonCount = CountBird.Bird;
        // Debug.Log(buttonCount);
        for (int i = 0; i < CountBomb.Bomb; i++)
        {
            int randomIndex = Random.Range(0, buttonCount);
            // 重複しないようにチェック
            while (bombIndexList.Contains(randomIndex))
            {
                randomIndex = Random.Range(0, buttonCount);
            }
            bombIndexList.Add(randomIndex);
        }
    }
    // 各ボタンにクリックイベントを設定する
    void SetButtonEvents()
    {
        for (int i = 0; i < CountBird.Bird; i++)
        {
            int buttonIndex = i;
            Button button = buttons[i];
            button.gameObject.SetActive(true);
            button.onClick.AddListener(() => OnButtonClick(buttonIndex, button));
        }
    }
    // ボタンがクリックされた時の処理
    void OnButtonClick(int buttonIndex, Button button)
    {
        if (bombIndexList.Contains(buttonIndex))
        {
            // 爆弾がクリックされた場合
            button.gameObject.SetActive(false); // ボタンを非アクティブにする（消す）
            OutPanel.SetActive(true);
            bombCount++;
            if(bombCount == bombIndexList.Count)
            {
                gameOverPanel.SetActive(true);
            }
            //最後の爆弾が押されたとき、ゲーム終了パネルを表示する
            /*  if (bombIndexList.Contains(buttonIndex) <0)
              {
                  gameOverPanel.SetActive(true);
              }
           */
        }
        else
        {
            // 爆弾以外がクリックされた場合
            // button.gameObject.SetActive(false); //消す場合
            button.interactable = false; // ボタンをクリック不能にする場合
            SafePanel.SetActive(true);
        }
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