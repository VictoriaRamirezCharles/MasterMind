using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	public EscogerColor escogerColor;

	void OnMouseOver()
	{
		escogerColor.MostrarBolasColores (gameObject);
	}
	public Material ColorBola()
	{

		return GetComponent<MeshRenderer> ().material;
		
    }

	public void CambiarColor(Material ColorNuevo)
	{
		//Solucionada?
		//Activa?

		GetComponent<MeshRenderer> ().material = ColorNuevo;
	}

}