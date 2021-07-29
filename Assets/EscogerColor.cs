using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscogerColor : MonoBehaviour {

	public GameObject[] BolasColores;
	public bool Mostrando = false;
	public GameObject BolaLlamante;



	void OnMouseExit()
	{
		EsconderBolasColores ();
	}
	public void MostrarBolasColores(GameObject bolaLlamante)
	{
		transform.position = bolaLlamante.transform.position;
		BolaLlamante = bolaLlamante;
		for (int i = 0; i < BolasColores.Length; i++) 
		{
			BolasColores [i].SetActive (true);
		}

		Mostrando = true;
	}

	public void EsconderBolasColores()
	{
		for (int i = 0; i < BolasColores.Length; i++) 
		{
			BolasColores [i].SetActive (false);
		}
		Mostrando = false;
	}
}
