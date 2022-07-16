using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlotHandler : MonoBehaviour
{
    public Object targetScene;

    public void onClick()
    {
        SceneManager.LoadScene(targetScene.name);
    }
}
