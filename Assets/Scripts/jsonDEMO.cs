
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
//using LitJson; 



public class jsonDEMO : MonoBehaviour {
	private string jsonString;
//	private JSONData itemData;

	// GameObject NucleonSpawner;

	void Start () {

		jsonString = File.ReadAllText (Application.dataPath + "/Resources/trash.json");
		Debug.Log (jsonString);

		var DATA = JSON.Parse (jsonString);


		var RefuseTrashAmount = DATA ["refuse"].AsFloat;
		Debug.Log ("Refuse Amount :: " + RefuseTrashAmount);

		GameObject.Find ("Nucleon Spawner").SendMessage ("getRefuseValue", RefuseTrashAmount);


		var PaperTrashAmount = DATA ["paper"].AsFloat;
		Debug.Log ("Paper Amount :: " + PaperTrashAmount);

		GameObject.Find("Nucleon Spawner").SendMessage ("getPaperValue", PaperTrashAmount);


		var MgpTrashAmount = DATA ["mgp"].AsFloat;
		Debug.Log ("MGP :: " + MgpTrashAmount);

		GameObject.Find ("Nucleon Spawner").SendMessage ("getMgpValue", MgpTrashAmount);

	}
	
	void Update () {
		
	}
}
