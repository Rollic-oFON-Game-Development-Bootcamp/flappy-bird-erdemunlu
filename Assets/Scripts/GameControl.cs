using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject startPanel;
    public GameObject flappyBird;
    public Rigidbody2D flappyBirdRigidBody;
    public float speedMultiplier = 1200F;


    public void Start()
    {
        flappyBirdRigidBody.isKinematic = true;
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
                flappyBirdRigidBody.isKinematic = false;
            }
        }
        
    }

    public void MoveFlappyBird()
    {
        flappyBirdRigidBody.AddForce(Vector2.up * speedMultiplier);
    }
}
