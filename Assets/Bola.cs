using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolas : MonoBehaviour{

    public EscojerColor escojerColor;
    public Material colorDefaul;
    Mesh meshFilter;

    public bool EsTiraObjetivo;

    void awake(){
        meshInicial = GetComponent<meshFilter> ().mesh;
        GetComponent<meshFilter> ().mesh = new Mesh();
         GetComponent<meshRenderer> ().material = colorDefaul;  

            }

            void OnMouseOver(){
                escojerColor.MostrarBolasColores(gameObject);
            }

            public Material ColorBola(){
                return GetComponent<meshFilter> ().material; 
            }

            public void CambiarColor (Material ColorNuevo){

                GetComponent<meshFilter> ().mesh = mesh=meshInicial();
                GetComponent<meshRenderer> ().material = ColorNuevo;
                GetComponentInParent<Bolas>().GetComponentInParent<Tira>().ActualizarCombinacionActual;
            }

}