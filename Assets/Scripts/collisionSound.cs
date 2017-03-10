//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class collisionSound : MonoBehaviour {
//
//	//volume: 0-1
//
//	//magnitude
//
//	void OnCollisionStay(Collision col) {
//
//		if (!audio.isPlaying && col.relativeVelocity.magnitude >= 2) {
//			audio.volume = col.relativeVelocity.magnitude / 13;
//			audio.Play ();
//		}
//	}
//}
