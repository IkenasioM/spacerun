using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour {

    public string sceneAccueil;
    public string sceneJeux;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void chargementScene(int a){
        if (a == 0)
        {
            SceneManager.LoadScene(this.sceneAccueil);
            return;
        }
        if (a == 1)
        {
            SceneManager.LoadScene(this.sceneJeux);
            return;
        }
        Debug.Log("indexer non trouvé");
    }

    public void exitGame() {
        Application.Quit();
    }
}
