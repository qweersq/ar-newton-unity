using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class page_routes_button : MonoBehaviour {
    // Home Menu Route
    public void HomeMenu() {
        SceneManager.LoadScene("HomeMenu");
    }

    // Newton 1 - Intro Route
    public void Newton1_Intro(string Newton1_Intro) {
        SceneManager.LoadScene("Newton1_Intro");
    }

    // Newton 1 - Play Route
    public void Newton1_Play(string Newton1_Play) {
        SceneManager.LoadScene("Newton1_Play");
    }

    // Newton 2 - Intro Route
    public void Newton2_Intro(string Newton2_Intro) {
        SceneManager.LoadScene("Newton2_Intro");
    }

    // Newton 2 - Play Route
    public void Newton2_Play(string Newton2_Play) {
        SceneManager.LoadScene("Newton2_Play");
    }

    // Newton 3 - Intro Route
    public void Newton3_Intro(string Newton3_Intro) {
        SceneManager.LoadScene("Newton3_Intro");
    }

    // Newton 3 - Play Route
    public void Newton3_Play(string Newton3_Play) {
        SceneManager.LoadScene("Newton3_Play");
    }
}
