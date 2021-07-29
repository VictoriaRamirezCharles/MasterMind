using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolas : MonoBehaviour{

    public GameObject[] ObjBolas;
    public Material[] Colores;

    public Material[] CombinacionActual(){
        Material[] Resultado = new Material[4];

        for (int i = 0; i < ObjBolas.length; i++)
        {
            Resultado[i]=ObjBolas [i].GetCompnent<Bolas> ().ColorBola();
        }

        return Resultado;

    }

    public void CombinarAleatoriamente(){

        for (int i = 0; i < ObjBolas.length; i++)
        {
            ObjBolas [i].GetCompnent<Bolas> ().CambiarColor (Colores [Random.Range (0, Colores.length)]);
        }
    }

    public bool TiraCompleta(){
        bool Resultado = true;
        for (int i = 0; i < ObjBolas.length; i++)
        {
            if(ObjBolas [i].GetCompnent<Bolas> ().ColorBola().color == colorDefaul.color){
                return false;
            }
        }

        return Resultado;
    }
}