using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject flashLight;
    bool toggleOnOff;
    RaycastHit hit;
    public float distance;
    public float batterylife;
    
	// Use this for initialization
	void Start () {
        toggleOnOff = true;
        flashLight.SetActive(toggleOnOff);
        distance = 2;
        batterylife = 60;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            toggleOnOff = !toggleOnOff;
        }

        flashLight.SetActive(toggleOnOff);

        batterylife -= Time.deltaTime;
        Debug.Log(batterylife);

        if (Input.GetKeyDown( KeyCode.E))
        {
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "battery")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}

