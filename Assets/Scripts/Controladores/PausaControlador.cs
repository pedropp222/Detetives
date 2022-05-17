using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaControlador : MonoBehaviour
{
    private bool paused = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        paused = !paused;
        foreach(IPausable pausable in ComponentFinder.Find<IPausable>())
        {
            pausable.OnPause(paused);
        }
    }
}
