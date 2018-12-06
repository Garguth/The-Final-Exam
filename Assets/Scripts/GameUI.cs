using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour {

    [SerializeField]
    Sprite BatteryLife;
    [SerializeField]
    Sprite BatteryLife1;
    [SerializeField]
    Sprite BatteryLife2;
    [SerializeField]
    Sprite BatteryLife3;
    [SerializeField]
    Sprite BatteryLife4;
    [SerializeField]
    Sprite BatteryLife5;
    Player player;
    [SerializeField]
    Image Battery;
    [SerializeField]
    private Text NoteBooksPicked;
    [SerializeField]
    private Text AnswerSheet;

    // Use this for initialization
    void Start () {

    }
    public void BatteryLife100()
    {
        Battery.sprite = BatteryLife;
    }
    public void BatteryLife80()
    {
        Battery.sprite = BatteryLife1;
    }
    public void BatteryLife60()
    {
        Battery.sprite = BatteryLife2;
    }
    public void BatteryLife40()
    {
        Battery.sprite = BatteryLife3;
    }
    public void BatteryLife20()
    {
        Battery.sprite = BatteryLife4;
    }
    public void BatteryLife0()
    {
        Battery.sprite = BatteryLife5;
    }
    public void SetNoteBookText(int num)
    {
        NoteBooksPicked.text = "" + num;
    }
    public void SetFinalAnswer()
    {
        AnswerSheet.GetComponent<Text>().enabled = true;
    }
    // Update is called once per frame
    void Update () {
       
	}
}
