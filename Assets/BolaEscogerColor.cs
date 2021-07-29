using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaEscogerColor : MonoBehaviour {

	Material _color;
	public EscogerColor escogerColor;

	void Awake()
	{
		_color = GetComponent<MeshRenderer> ().material;
	}

	void OnMouseDown()
	{
		escogerColor.BolaLlamante.GetComponent<Bola> ().CambiarColor (_color);
	}
}
