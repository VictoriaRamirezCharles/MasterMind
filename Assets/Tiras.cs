using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tira : MonoBehaviour{

        public bool EsActiva=false;
        public bool LineaCompleta=false;

        public GameObject Soluciones;
        public GameObject BolasObj;
        public Material[] CombinacionActual;

        public void ActualizarCombinacionActual(){
            CombinacionActual = BolasObj.GetCompnent<Bolas> ().CombinacionActual();
            LineaCompleta = BolasObj.GetCompnent<Bolas> ().TiraCompleta ();
        }
}