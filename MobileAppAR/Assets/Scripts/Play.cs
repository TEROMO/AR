using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public string sceneName;
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener (TaskOnClick); 
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene(sceneName); 
    }
}
