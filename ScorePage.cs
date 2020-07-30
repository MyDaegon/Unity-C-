using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScorePage : MonoBehaviour
{
    public Text Pontuacao, Recorde;
    void Start()
    {
        
    }

    
    void Update()
    {
        Pontuacao.text = "Pontuação: " + PlayerCont.Pontuacao.ToString() + " Pontos";
        //Tempo.text = GameController.tempo.ToString() + " Segundos";
        if(PlayerCont.Pontuacao > PlayerPrefs.GetInt("High")){
            PlayerPrefs.SetInt("High", PlayerCont.Pontuacao);
        }
        Recorde.text = "Maior Pontuação: " + PlayerPrefs.GetInt("High").ToString() + " Pontos";
    }
}
