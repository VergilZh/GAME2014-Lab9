using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMang : MonoBehaviour
{
    public void onStartPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
