using UnityEngine;

public class Losing : MonoBehaviour
{
    
    void Update()
    {
        if(transform.position.x >= 15.9){
            Destroy(gameObject);
        }
    }
}