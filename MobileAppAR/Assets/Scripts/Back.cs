using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public string sceneName;
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
