using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

	if(Input.GetKeyDown(KeyCode.P))
	{
		SceneManager.LoadScene("TransitionScene");
	}
        
    }

    public void DoQuit()
{

	Application.Quit();
}

public void MainMenu()
{

	SceneManager.LoadScene("0 Main Menu");

}


public void resume()
{
	SceneManager.LoadScene("TransitionScene");
}

}
