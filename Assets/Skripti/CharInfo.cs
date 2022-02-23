using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharInfo : MonoBehaviour {
	public string teksts;
	public int vecums = 0;
	public GameObject ievadesLauks;
	public GameObject vecumsLauks;
	public GameObject TekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		vecums = int.Parse(vecumsLauks.GetComponent<Text> ().text);
			TekstaAttelosanasLauks.GetComponent<Text> ().text = "Tēls " + teksts.ToUpper () + " ir " + vecums + " gadus vecs!";
	}
}
