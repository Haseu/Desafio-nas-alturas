using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    public float velocidade = 0.1f;
    [SerializeField]
    private float variacaoY;

    private void Awake() 
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));    
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
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
