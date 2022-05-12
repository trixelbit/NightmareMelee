using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem
{
    private static List<IPausable> _pausableRegistry;
    public bool IsPaused = false;

    public void Pause()
    {
        foreach (IPausable entry in _pausableRegistry)
        { 
            entry.OnPause();
        }
    }

    public void UnPause()
    {
        foreach (IPausable entry in _pausableRegistry)
        {
            entry.OnResume();
        }
    }

    public static void RegisterPausable(IPausable entry)
    { 
        _pausableRegistry.Add(entry);
    }
}
