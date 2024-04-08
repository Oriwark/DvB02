using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class enemigos : MonoBehaviour
{
    public GameObject prefabBacteria;
    private float randomX;
    private float randomY;

    
    void Start()
    {
        StartCoroutine(oleadaBacterias());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CrearBacteria()
    {

        randomX = Random.Range(-2.75f, 2.75f);
        GameObject a = Instantiate(prefabBacteria) as GameObject;
        a.transform.position = new Vector3(randomX, 5.72f, 0f);

    }
    IEnumerator oleadaBacterias()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            CrearBacteria();
        }
    }
}

