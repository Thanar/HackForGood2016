using UnityEngine;
using System.Collections;

public class GEAnimStarter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GEAnimSystem.Instance.MoveIn(this.transform, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
