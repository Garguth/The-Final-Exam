using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

	// Use this for initialization
	public void StartGame ()
    {
        SceneManager.LoadScene("Final");
	}
    public void menuScene()
    {
        SceneManager.LoadScene("GameMenu");
    }
    public void CreditScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void Quit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
