using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour
{
    public bool Paused { get; set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerPause()
    {
        if (Paused)
        {
            Paused = false;
            Game.Resume();
        }
        else
        {
            Paused = true;
            Game.Pause();
        }
    }
}
