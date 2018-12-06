using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBook : MonoBehaviour {

    [SerializeField]
    Player player;
    public GameManager gamenanager;
    public GameObject door;
    private int numberOfNoteBooks;

	// Use this for initialization
	void Start () {
        numberOfNoteBooks = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (numberOfNoteBooks == 4)
        {
            door.SetActive(true);
        }
	}
    void PickUpNotebook()
    {
        Destroy(this.gameObject);
        numberOfNoteBooks++;
        
    }
}
