using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenLogic : MonoBehaviour
{
    public AudioSource buttonSFX;
    public void onClick()
    {
        buttonSFX.Play();
        SceneManager.LoadScene("Mercy Flappy Bird");
    }
}
