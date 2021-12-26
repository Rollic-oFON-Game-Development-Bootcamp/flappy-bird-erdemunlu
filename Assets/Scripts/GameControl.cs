using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject startPanel;
    public GameObject flappyBird;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!startPanel.activeSelf)
            {
                startPanel.SetActive(false);
            }
            else
            {
                startPanel.SetActive(false);
            }
        }
    }
}
