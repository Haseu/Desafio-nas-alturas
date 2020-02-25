using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    public float velocidade = 0.1f;
    [SerializeField]
    private float variacaoY;
    private Vector3 posicaoDoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;

    private void Awake() 
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));    
    }

    private void Start() {
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        
        if (!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x)
        {
            this.pontuei = true;
            this.pontuacao.adicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        this.destruir();
    }

    public void destruir()
    {
        GameObject.Destroy(this.gameObject);
    }


}
