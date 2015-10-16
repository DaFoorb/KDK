using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {

	//public Camera currentCamera ;
	RuntimePlatform pl= Application.platform ;
	RaycastHit2D raycast ;
	Ray ray ;
	Physics2D ph2d ;

	// Use this for initialization
	void Start () {
		//raycast= new RaycastHit2D() ;
		Debug.Log ("TU RENTRES ?") ;
	}
	
	// Update is called once per frame
	void Update () {
		// /!\ Obliger de tester sur un téléphone à cause du Input.touchCount
			for (int n_countPush= 0 ;
			     n_countPush < Input.touchCount ;
			     n_countPush++) {

				if (Input.GetTouch(n_countPush).phase == TouchPhase.Began) {
					RaycastHit2D rh2d= Physics2D.Raycast(Input.GetTouch(n_countPush).position,
					                                     -Vector2.up) ;
					if (rh2d != null) {
						rh2d.transform.gameObject.GetComponent<SpriteRenderer>().color.Equals(Color.red) ;
					}
				}
			}
		}
	}

