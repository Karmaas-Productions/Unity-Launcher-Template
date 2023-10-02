using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectPlatform : MonoBehaviour
{
    
    void Start()
    {
        
#if UNITY_STANDALONE_WIN
        SceneManager.LoadScene("Launcher-Windows");
#endif

#if UNITY_STANDALONE_OSX
        SceneManager.LoadScene("Launcher-macOS");
#endif

#if UNITY_STANDALONE_LINUX
        SceneManager.LoadScene("Launcher-Linux");
#endif
    }
    
}
