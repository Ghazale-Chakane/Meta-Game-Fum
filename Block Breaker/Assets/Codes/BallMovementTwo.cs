using UnityEngine;

public class BallMovementTwo : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb.AddForce(-250, 0, -500);
    }
}
