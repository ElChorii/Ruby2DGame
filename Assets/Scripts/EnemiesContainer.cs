using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemiesContainer : MonoBehaviour
{
    public static EnemiesContainer instance;

    [SerializeField] GameObject contenedorEnemigos;
    
    [SerializeField] TextMeshProUGUI etiquetaEnemigosRestantes;
    [SerializeField] TextMeshProUGUI etiquetaEnemigosTotales;

    int enemigosRestantes = 0;
    int enemigosTotales = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        SumarEnemigos(contenedorEnemigos.transform.childCount);
    }

    public void SumarEnemigos(int enemigosASumar)
    {
        enemigosTotales += enemigosASumar;
        enemigosRestantes += enemigosASumar;

        etiquetaEnemigosTotales.text = enemigosTotales.ToString();
        etiquetaEnemigosRestantes.text = enemigosRestantes.ToString();
    }

    public void RestarEnemigo()
    {
        enemigosRestantes -= 1;
        etiquetaEnemigosRestantes.text = enemigosRestantes.ToString();
    }
}
