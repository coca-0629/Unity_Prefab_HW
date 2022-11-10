using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_transition : MonoBehaviour
{
    public Texture2D icon = null;
    private int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (count == 10) {
            SceneManager.LoadScene ("Scene2", LoadSceneMode.Single);
        }
    }

    void OnCollisionEnter(Collision collided) {
        count++;
    }

    void OnGUI() {
        GUI.DrawTexture (new Rect(Screen.width - 64, Screen.height - 64, 64, 64), icon);
        GUI.Label(new Rect(Screen.width - 140, Screen.height - 40, 128, 32), "Collided : " + count.ToString());
    }
}
