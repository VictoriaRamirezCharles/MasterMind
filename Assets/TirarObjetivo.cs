using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiraObjetivo : MonoBehaviour{

    public bool LineaCompleta=false;

    //public GameObject Soluciones;
    public GameObject BolasObj;
    public Material[] CombinacionActual;

    public void ActualizarCombinacionActual(){
        CombinacionActual = BolaObj.GetComponent<Bolas> ().CombinacionActual();
        LineaCompleta = BolasObj.GetComponen<Bolas> ().TiraCompleta(); 
            }

}