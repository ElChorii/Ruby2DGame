using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesContainer : MonoBehaviour
{
    public float quedaParaQueAparezcan = 5f;
    //public bool spawneaElSiguiente = false;
    public GameObject robotico1;
    public GameObject robotico2;
    public GameObject robotico3;
    public GameObject robotico4;
    public GameObject robotico5;
    public GameObject robotico6;
    float numeroDeEnemigos = 0;

    // Update is called once per frame
    void Update()
    {
        quedaParaQueAparezcan = quedaParaQueAparezcan -1 * Time.deltaTime;
        if (quedaParaQueAparezcan < 0)
        {
            AparecenTodos(); 
        }
    }
    public void AparecenTodos()
    {
        //spawneaElSiguiente = true;
        robotico1.SetActive(true);
        robotico2.SetActive(true);
        robotico3.SetActive(true);
        robotico4.SetActive(true);
        robotico5.SetActive(true);
        robotico6.SetActive(true);
        numeroDeEnemigos = numeroDeEnemigos + 5;
    }
}
