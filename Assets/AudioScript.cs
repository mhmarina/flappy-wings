using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private static AudioScript instance;
    void Awake()
    {
        if (instance != null) {
                Destroy(gameObject);
            }
        else
        {
            instance = GameObject.FindGameObjectWithTag("BGM").GetComponent<AudioScript>();
            DontDestroyOnLoad(instance);
        }
    }
}
