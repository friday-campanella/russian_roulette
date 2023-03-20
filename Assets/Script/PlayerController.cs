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
    //public AudioClip karaageSE;
    //public AudioSource karaageAudio;

    void Start()
    {
        bombIndexList = new List<int>();
        SetButtonEvents();
        SetBombs();
    }
    // ���e�������_���ɐݒu����
    void SetBombs()
    {
        int buttonCount = CountBird.Bird;
        // Debug.Log(buttonCount);
        for (int i = 0; i < CountBomb.Bomb; i++)
        {
            int randomIndex = Random.Range(0, buttonCount);
            // �d�����Ȃ��悤�Ƀ`�F�b�N
            while (bombIndexList.Contains(randomIndex))
            {
                randomIndex = Random.Range(0, buttonCount);
            }
            bombIndexList.Add(randomIndex);
        }
    }
    // �e�{�^���ɃN���b�N�C�x���g��ݒ肷��
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
    // �{�^�����N���b�N���ꂽ���̏���
    void OnButtonClick(int buttonIndex, Button button)
    {
        if (bombIndexList.Contains(buttonIndex))
        {
            // ���e���N���b�N���ꂽ�ꍇ
            button.gameObject.SetActive(false); // �{�^�����A�N�e�B�u�ɂ���i�����j
            OutPanel.SetActive(true);
            bombCount++;
            if(bombCount == bombIndexList.Count)
            {
                gameOverPanel.SetActive(true);
            }
            //�Ō�̔��e�������ꂽ�Ƃ��A�Q�[���I���p�l����\������
            /*  if (bombIndexList.Contains(buttonIndex) <0)
              {
                  gameOverPanel.SetActive(true);
              }
           */
        }
        else
        {
            // ���e�ȊO���N���b�N���ꂽ�ꍇ
            // button.gameObject.SetActive(false); //�����ꍇ
            button.interactable = false; // �{�^�����N���b�N�s�\�ɂ���ꍇ
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