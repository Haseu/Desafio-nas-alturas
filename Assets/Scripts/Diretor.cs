using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imageGameOver;
    public void finalizarJogo()
    {
        Time.timeScale = 0;
        //habilitar image gameover
        this.imageGameOver.SetActive(true);
    }
}
