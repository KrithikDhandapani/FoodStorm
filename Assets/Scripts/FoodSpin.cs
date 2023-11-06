using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpin : MonoBehaviour
{
    private Vector3 rotate = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(rotate);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rotate = new Vector3(0, 0, 0);
            transform.Rotate(rotate);
        }
    }
    
    
}
