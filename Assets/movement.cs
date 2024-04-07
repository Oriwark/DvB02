using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MovePlayer()
    {
        if (Input .GetAxisRaw ("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
        }
        else if (Input.GetAxisRaw ("Vertical") < 0f){
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            transform.position = temp;
        }
    }
}
