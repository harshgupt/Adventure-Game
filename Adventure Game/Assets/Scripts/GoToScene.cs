using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    public static string sceneName;

    public void GoToMain()
    {
        sceneName = "Main";
        SceneManager.LoadScene("Main");
    }

	public void GoToLevel()
    {
        sceneName = "Level Template";
        SceneManager.LoadScene("Level Template");
    }

    public void GoToMine()
    {
        sceneName = "Mine";
        SceneManager.LoadScene("Mine");
    }

    public void GoToForge()
    {
        sceneName = "Forge";
        SceneManager.LoadScene("Forge");
    }

    public void GoToUpgrade()
    {
        sceneName = "Upgrades";
        SceneManager.LoadScene("Upgrades");
    }

    public void GoToCoinMine()
    {
        sceneName = "Coin Mine";
        SceneManager.LoadScene("Coin Mine");
    }
}
