using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharHolder : MonoBehaviour {
	public GameObject kleita;
	public GameObject kleitaReal;
	public GameObject svarkiReal;
	public GameObject svarki;
	public GameObject slaideris;
	public GameObject slaiderisPlatums;
	public GameObject attelaTuretajs;
	public Sprite[] attelumasivs;

	void Start(){
		kleita.SetActive (false);
		svarki.SetActive (false);
	}

	public void izkritosais(int skaitlis){
		if (skaitlis == 0){
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [0];
		kleita.SetActive (false);
		svarki.SetActive (false);
			kleitaReal.SetActive (false);
			svarkiReal.SetActive (false);
	}
		else if (skaitlis == 1){
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [1];
			kleita.SetActive (true);
			svarki.SetActive(true);
	}
}
	public void mainitGarumu(){
		float izmers = slaideris.GetComponent<Slider> ().value;
		float izmersPlatums = slaiderisPlatums.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1f*izmers, 1f*izmersPlatums);
	}
	public void mainitPlatumu(){
		float izmers = slaiderisPlatums.GetComponent<Slider> ().value;
		float izmersGarums = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1f*izmersGarums, 1f*izmers);
	}
}
