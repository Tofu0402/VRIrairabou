using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRetry : MonoBehaviour
{

    public void OnPushedButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //現在のシーンをもう一度読み込む
    }
}
