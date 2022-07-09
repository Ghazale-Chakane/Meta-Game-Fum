using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Movement : MonoBehaviour
{
  private const float Paddle_Speed = 0.05f;
    void Start() {
        
    }


    void Update() {
        if (Input.GetKey("left")){
            transform.Translate(0,0,-Paddle_Speed);
        }
        else if (Input.GetKey("right")){
            transform.Translate(0,0,Paddle_Speed);
        }

        if(transform.position.x <= -9.6f){
            transform.position = new Vector3(-9.6f, transform.position.y, transform.position.z);
        }
        if(transform.position.x >= 9.6f){
            transform.position = new Vector3(9.6f, transform.position.y, transform.position.z);
        }
    }
}
