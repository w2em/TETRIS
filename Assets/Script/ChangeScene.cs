using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // �V�[������ݒ肷�邽�߂�SerializeField�t�B�[���h
    [SerializeField] string sceneName;
    public void change_button()
    {
        SceneManager.LoadScene(sceneName);
    }
}
