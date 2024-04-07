using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class disparo : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;

        }
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    //{
        //if(collision.tag == "Pared")
        //{
          //  Destroy (bulletSpawnPoint);
          //  Destroy(gameObject);
      //  }
    //}
}
