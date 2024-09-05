using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // シーン名を設定するためのSerializeFieldフィールド
    [SerializeField] string sceneName;
    public void change_button()
    {
        SceneManager.LoadScene(sceneName);
    }
}
