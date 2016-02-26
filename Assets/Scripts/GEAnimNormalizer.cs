using UnityEngine;
using System.Collections;

public class GEAnimNormalizer : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        GEAnimSystem.Instance.m_GUISpeed = 1.0f;
        GEAnimSystem.Instance.m_AutoAnimation = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
