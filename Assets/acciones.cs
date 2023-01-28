using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class acciones : MonoBehaviour
{
	public TextMeshProUGUI output;
	public TextMeshProUGUI input; 

	public void MiFuncion() {
		string miTexto = input.text;
		output.SetText(miTexto);
	}
}
