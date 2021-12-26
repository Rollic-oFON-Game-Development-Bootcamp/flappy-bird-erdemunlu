using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject startPanel;
    public GameObject flappyBird;
    public Rigidbody2D flappyBirdRigidBody;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!startPanel.activeSelf)
            {
                MoveFlappyBird();
            }
            else
            {
                startPanel.SetActive(false);
            }
        }
    }

    public void MoveFlappyBird()
    {
        flappyBirdRigidBody.velocity = Vector2.up;
    }
}
