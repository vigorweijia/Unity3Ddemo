using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPanel : MonoBehaviour
{
    public UIWidget panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show() {
        panel.gameObject.SetActive(true);
    }

    public void close() {
        panel.gameObject.SetActive(false);
    }
}
