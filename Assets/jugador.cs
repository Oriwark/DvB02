using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    private float movimientoFuerza = 10f;

    private Rigidbody2D rgbd2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementY = Input.GetAxisRaw("Vertical");
        Vector2 posicionJug = transform.position;

        posicionJug = posicionJug + new Vector2 (movementY, 0f) * movimientoFuerza * Time.deltaTime;

        transform.position = posicionJug;
    }
}
