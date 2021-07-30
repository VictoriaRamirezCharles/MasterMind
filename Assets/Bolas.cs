using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolas : MonoBehaviour {

	public GameObject[] objBolas;
	public Material[] Colores;

	public Material[] CombinacionActual()
	{
		Material[] Resultado = new Material[4];
		for (int i = 0; i < objBolas.Length; i++) 
		{
			Resultado[i] = objBolas [i].GetComponent<Bola> ().ColorBola();
			
		}

		return Resultado;
		
	}

	public void CombinarAletoriamente()
	{
		for (int i = 0; i < objBolas.Length; i++) 
		{
			objBolas [i].GetComponent<MeshRenderer> ().material = Colores [Random.Range (0, Colores.Length)];
		}
	}
}
