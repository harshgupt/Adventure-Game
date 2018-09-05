using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }

	public void GoToLevel()
    {
        SceneManager.LoadScene("Level Template");
    }

    public void GoToMine()
    {
        SceneManager.LoadScene("Mine Template");
    }

    public void GoToForge()
    {
        SceneManager.LoadScene("Forge Template");
    }
}
