using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class levelmanager : MonoBehaviour {

    // Use this for initialization
    public void loadnextlevel() {
        SceneManager.LoadScene("Forest");
    }

    public void quit() {
        Application.Quit();
        print("game quit");
    }
}
