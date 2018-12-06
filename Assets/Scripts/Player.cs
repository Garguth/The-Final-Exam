using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject flashLight;
    public bool toggleOnOff;
    RaycastHit hit;
    public float distance;
    public float batterylife;
    [SerializeField]
    GameUI gameUI;

    public GameManager gamemanager;
    // Use this for initialization
    void Start () {

        toggleOnOff = true;
        flashLight.SetActive(toggleOnOff);
        distance = 2;
        batterylife = 100;
	}
	
	// Update is called once per frame
	void Update () {

        if (toggleOnOff == true)
        {
            batterylife -= Time.deltaTime;
        }
 
        //Debug.Log(batterylife);
        if (batterylife <= 100 && batterylife >= 80)
        {
            gameUI.BatteryLife100();
        }
        if (batterylife <= 80 && batterylife >= 60)
        {
            gameUI.BatteryLife80();

        }
        if (batterylife <= 60 && batterylife >= 40)
        {
            gameUI.BatteryLife60();
        }
        if (batterylife <= 40 && batterylife >= 20)
        {
            gameUI.BatteryLife40();
        }
        if (batterylife <= 20 && batterylife >= 0)
        {
            gameUI.BatteryLife20();
        }
        if (batterylife <= 0)
        {
            flashLight.SetActive(false);
            gameUI.BatteryLife0();
        }
        else
        {
            if (Input.GetMouseButtonDown(1))
            {
                toggleOnOff = !toggleOnOff;
            }

            flashLight.SetActive(toggleOnOff);
        }
        if (Input.GetKeyDown( KeyCode.E))
        {
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "battery")
            {
                Destroy(hit.collider.gameObject);
                batterylife = batterylife + 20;
            }
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "notebook")
            {
                Destroy(hit.collider.gameObject);
                // sheet picked up
            }
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "Door")
            {
                gamemanager.CreditScene();
            }
            
        }
    }
}

