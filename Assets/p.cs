using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class p : MonoBehaviour
{
    float speed = 0.1f;
    bool move6;
    bool move4;
    bool move8;
    float fallSpeed = 0.15f;
    float jumpSpeed = 0.2f;
    int jumpCount = 0;
    int maxJumpCount = 60;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) move6 = true;
        if (Input.GetKeyDown(KeyCode.A)) move4 = true;
        if (Input.GetKeyUp(KeyCode.D)) move6 = false;
        if (Input.GetKeyUp(KeyCode.A)) move4 = false;
        if (Input.GetKeyDown(KeyCode.Space)) move8 = true;
        if (Input.GetKeyUp(KeyCode.Space)) move8 = false;
        Moves();


    }

    void Moves()
    {
        if (move6) transform.position += Vector3.right * speed;
        if (move4) transform.position += Vector3.left * speed;
        if (move8)
        {
            transform.position += Vector3.up * jumpSpeed;
            jumpCount++;
            if (jumpCount == maxJumpCount)
            {
                move8 = false;
            }
        }
      
    }


}
