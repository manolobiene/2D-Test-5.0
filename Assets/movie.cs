using UnityEngine;
using System.Collections;

public class movie : MonoBehaviour {
	public MovieTexture mov;

	void Start () {
		GetComponent<Renderer> ().material.mainTexture = mov;
		GetComponent<AudioSource> ().clip = mov.audioClip;
		mov.Play ();
		GetComponent<AudioSource> ().Play ();
	}
}
