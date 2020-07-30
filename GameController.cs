using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text TextoDeTempo, TextoDeVida, TextoDePontuacao;
    public GameObject Objeto;
    public float TempoParaSpawn;
    public Transform PosicaoDoObjeto;
    public static int Dest;
    public static float tempo;
    public static int Vida, Pontuacao;
    void Start()
    {
        tempo = 0;
        Pontuacao = 0;
        StartCoroutine(Instant());
    }
    void FixedUpdate()
    {
        //Vida = PlayerController.life;
        TextoDeTempo.text = Mathf.RoundToInt(tempo).ToString();
        TextoDeVida.text = Vida.ToString();
        TextoDePontuacao.text = Pontuacao.ToString();
        if(Vida > 0){
        tempo += Time.deltaTime;
        }
        Pontuacao = Dest * Mathf.RoundToInt(tempo);
    }

    IEnumerator Instant(){

        while(true){

            Instantiate(Objeto, PosicaoDoObjeto.position, transform.rotation);

        yield return new WaitForSeconds(TempoParaSpawn);    
        }
    }
}