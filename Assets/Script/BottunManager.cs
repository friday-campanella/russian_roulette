using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottunManager : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }

public void HomeScene()
    {
        SceneManager.LoadScene("Home");
    }
    public void Restart()
    {
        //���V�[�������X�^�[�g
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
