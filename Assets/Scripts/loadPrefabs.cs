using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadPrefabs : MonoBehaviour {

	public GameObject bananaPrefab;
	public GameObject deskPrefab;
	public GameObject meatPrefab;

	public GameObject toiletPaperPrefab;
	public GameObject milkPrefab;
	public GameObject cardboardPrefab;

	public GameObject bottlePrefab;
	public GameObject sprayPrefab;
	public GameObject binPrefab;

	public int Radius;
	public Transform cam;


	public void getRefuseValue(float RefuseTrashAmount){

		int count = (int)Mathf.Round (RefuseTrashAmount /15);
		StartCoroutine(addRefuseObject(count,0));

	}

	IEnumerator addRefuseObject(int totalCount, int currentCount){

		yield return new WaitForSeconds(0.2f);
//		print ("hi " + currentCount);

		GameObject prefabChoice = bananaPrefab;

		if (currentCount <  totalCount / 3) {
			prefabChoice = bananaPrefab;
//			print ("banana" + currentCount);
		} 
		else if(currentCount >= totalCount/3 && currentCount < (totalCount/3) * 2) {
			prefabChoice = deskPrefab;
//			print ("desk" + currentCount);
		}
		else if(currentCount >= (totalCount/3) * 2) {
			prefabChoice = meatPrefab;
//			print ("meat" + currentCount);
		}

		Instantiate (prefabChoice, Random.onUnitSphere * Radius, Quaternion.identity);
		currentCount++;

		if (currentCount < totalCount) {
			StartCoroutine(addRefuseObject(totalCount,currentCount));
		}
	}



	public void getPaperValue(float PaperTrashAmount){

		int count = (int)Mathf.Round (PaperTrashAmount / 15);
		StartCoroutine(addPaperObject(count,0));

	}

	IEnumerator addPaperObject(int totalCount, int currentCount){

		yield return new WaitForSeconds(0.2f);
		//		print ("hi " + currentCount);

		GameObject prefabChoice = toiletPaperPrefab;

		if (currentCount <  totalCount / 3) {
			prefabChoice = toiletPaperPrefab;
//			print ("toilet paper" + currentCount);
		} 
		else if(currentCount >= totalCount/3 && currentCount < (totalCount/3) * 2) {
			prefabChoice = milkPrefab;
//			print ("milk" + milkPrefab);
		}
		else if(currentCount >= (totalCount/3) * 2) {
			prefabChoice = cardboardPrefab;
//			print ("cardboard" + cardboardPrefab);
		}

		Instantiate (prefabChoice, Random.onUnitSphere * Radius, Quaternion.identity);
		currentCount++;

		if (currentCount < totalCount) {
			StartCoroutine(addPaperObject(totalCount,currentCount));
		}

	}


	public void getMgpValue(float MgpTrashAmount){

		int count = (int)Mathf.Round (MgpTrashAmount / 15);

		StartCoroutine(addMgpObject(count,0));

	}

	IEnumerator addMgpObject(int totalCount, int currentCount){

		yield return new WaitForSeconds(0.2f);
		//		print ("hi " + currentCount);

		GameObject prefabChoice = bottlePrefab;

		if (currentCount <  totalCount / 3) {
			prefabChoice = bottlePrefab;
		} 
		else if(currentCount >= totalCount/3 && currentCount < (totalCount/3) * 2) {
			prefabChoice = sprayPrefab;
		}
		else if(currentCount >= (totalCount/3) * 2) {
			prefabChoice = binPrefab;
		}

		Instantiate (prefabChoice, Random.onUnitSphere * Radius, Quaternion.identity);

		currentCount++;

		if (currentCount < totalCount) {
			StartCoroutine(addMgpObject(totalCount,currentCount));
		}

	}

}
