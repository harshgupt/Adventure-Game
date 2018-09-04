using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

	public void GoToLevel()
    {
        SceneManager.LoadScene("Level Template");
    }

    public void GoToMine()
    {
        SceneManager.LoadScene("Mine Template");
    }
}
