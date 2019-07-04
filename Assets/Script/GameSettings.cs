using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public TweenPosition startPanel;
    public TweenAlpha backgroundDisappear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onStartGameClicked() {
        startPanel.PlayForward();
        backgroundDisappear.PlayForward();
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
    }

    public void onOptionClicked() {
    }
    public void onQuitClicked() {
    }
}
