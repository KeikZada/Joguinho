using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
    private SpriteRenderer sprite;
    private CircleCollider2D collider;

    public GameObject coletado;
    public int Pontos;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CircleCollider2D>();
    }

    void OntriggerEnter2D(Collider2D colision)
    {
        if(colision.gameObject.tag == "Player")
        {
            sprite.enabled   = false;
            collider.enabled = false;

            coletado.SetActive(true);

            // Chama o método da classe SavePoints para armazenar os pontos
            SavePoints.acesso.TotalPontos += Pontos;

            SavePoints.acesso.atualizaPontosText();
            
            //Destroy a frua e define tempo para exibicao do colleted
            Destroy(gameObject, 0.5f);
        }
    }
}
