using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePoints : MonoBehaviour
{
    public int TotalPontos;
    public Text contador;

    public GameObject gameOver;

    public static SavePoints acesso;
    // Start is called before the first frame update
    void Start()
    {
        acesso = this;
    }
    public void atualizaPontosText() => contador.text =  TotalPontos.ToString();

    public void ShowGameOver()
    {
        gameOver.SetActive(true);

    }
    
}
