﻿using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imageGameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;

    private void Start() {
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    public void finalizarJogo()
    {
        Time.timeScale = 0;
        //habilitar image gameover
        this.imageGameOver.SetActive(true);
    }

    public void reiniciarJogo()
    {
        this.imageGameOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.reiniciar();
        this.destruirObstaculos();
        this.pontuacao.reiniciar();
    }

    private void destruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obstaculo in obstaculos)
        {
            obstaculo.destruir();
        }
    }
}
