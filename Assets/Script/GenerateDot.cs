using UnityEngine;
using System.Collections;

public class GenerateDot : MonoBehaviour {
	public Transform tr_dot ;
	int i_rdmDots ;
	
	void Start () {
		// On génère un nombre aléatoire de points pour la figure en cours
		int i_rdmDots= Random.Range(2, 5) ;

		for (int i_it= 0 ;
		     i_it < i_rdmDots ;
		     i_it++) {
			Transform tmp= tr_dot ;
			tmp.name= "Dot_"+ i_it ;
			Instantiate(tmp, 
			            new Vector3(Random.Range (-8, 8), 
			            			Random.Range(-13, 13), 
			            			0), 
			            Quaternion.identity) ;
			}
		}

	void Update () {
	
	}
}
