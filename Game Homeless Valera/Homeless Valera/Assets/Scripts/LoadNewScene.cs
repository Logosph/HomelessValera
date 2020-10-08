using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{

    public Button beginButton;

    // Start is called before the first frame update
    void Start()
    {
        beginButton.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
