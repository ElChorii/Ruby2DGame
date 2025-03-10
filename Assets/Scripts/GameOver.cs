using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;

    [SerializeField] GameObject ganasteCanvas;
    [SerializeField] GameObject perdisteCanvas;


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
        ganasteCanvas.SetActive(false);
        perdisteCanvas.SetActive(false);
    }

    public void PartidaGanada()
    {
        ganasteCanvas.SetActive(true);
    }

    public void PartidaPerdida()
    {
        perdisteCanvas.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("MainScene");
    }
}
