using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class enemigos : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    [SerializeField] private Transform[] puntos;
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private float tiempoEnemigos;

    private float tiempoSiguenteEnemigo;
    // Start is called before the first frame update
    private void Start() {
        maxX = puntos.Max(punto => punto.position.x);
        minX = puntos.Min(punto => punto.position.x);
        maxY = puntos.Max(punto => punto.position.y);
        minY = puntos.Min(punto => punto.position.y);
    }

    private void Update() {
        tiempoSiguenteEnemigo += Time.deltaTime;
        if (tiempoSiguenteEnemigo >= tiempoEnemigos) {
            tiempoSiguenteEnemigo = 0;
            CrearEnemigo();
        }
    }

    private void CrearEnemigo() {
        int numeroEnemigo = Random.Range(0, enemys. Length);
        Vector2 posicionAleatoria = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxX));
        Instantiate(enemys[numeroEnemigo], posicionAleatoria, Quaternion.identity);
    }
}
