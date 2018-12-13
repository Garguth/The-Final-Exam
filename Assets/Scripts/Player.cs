using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject flashLight;
    public GameObject AnswerSheet;
    public bool toggleOnOff;
    RaycastHit hit;
    public float distance;
    public float batterylife;
    private bool AudioIsLooping = true;
    [SerializeField]
    GameUI gameUI;
    private int numberOfNoteBooks;

    public GameManager gamemanager;
    public AudioManager audioManager;
    // Use this for initialization
    void Start () {

        toggleOnOff = true;
        distance = 2;
        batterylife = 160;

        // play backgroundmusic loop
	}
	
	// Update is called once per frame
	void Update () {
        if (numberOfNoteBooks == 4)
        {
            AnswerSheet.SetActive(true);
            gameUI.SetFinalAnswer();
        }
        if (toggleOnOff == true)
        {
            batterylife -= Time.deltaTime;
        }
 
        if (batterylife <= 160 && batterylife >= 80)
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
        if (batterylife == 40)
        {
            audioManager.Bat_Tery(true);
        }
        if (batterylife == 41)
        {
            audioManager.Bat_Tery(false);
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
            //if (Input.GetMouseButtonDown(1))
            //{
            //    toggleOnOff = !toggleOnOff;
            //}

            //flashLight.SetActive(toggleOnOff);
        }
        if (Input.GetKeyDown( KeyCode.E))
        {
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "battery")
            {
                Destroy(hit.collider.gameObject);
                batterylife = batterylife + 20;
                audioManager.Pickup(0);
            }
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "notebook")
            {
                Destroy(hit.collider.gameObject);
                numberOfNoteBooks++;
                // sheet picked up
            }
            if (Physics.Raycast(ray, out hit, distance) && hit.collider.gameObject.tag == "Answer Sheet")
            {
                gamemanager.CreditScene();
            }
            
        }
        gameUI.SetNoteBookText(numberOfNoteBooks);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            audioManager.PlayerDeath(0);
            gamemanager.CreditScene();
        }
    }
}

