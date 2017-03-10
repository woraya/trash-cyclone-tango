using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class sketch : MonoBehaviour {

	public GameObject plane;
	public float jitterRange = 0.3f;


	Mesh mesh;

	List<Vector3> verts = new List<Vector3>();
	//	Vector3[] vertices;

	void Start () {

		mesh = plane.GetComponent<MeshFilter>().mesh;
		Debug.Log ("The plane has " + mesh.vertexCount + " vertices.");
	
		UpdateVertices ();
	}

	void UpdateVertices() {
		verts.Clear ();

		for (int i = 0; i < mesh.vertexCount; i++) {	// iterating through all the vertices
			Vector3 newPos = mesh.vertices [i];			// going through every single points & make a copy them & put intp newPos variable
			newPos.y += Random.Range (-jitterRange, jitterRange);		// make new random position
			newPos.y += (0 - newPos.y) * .12f;			// ease toward 0 : Dampening algorithm ***
			verts.Add (newPos);							// add the new vertices and push them
		}

		mesh.SetVertices (verts);						// telling the mesh that we're updating the new vertices
		mesh.RecalculateNormals();						// so shadows calculate better
	}

	void Update () {
		UpdateVertices ();
		
	}
}
