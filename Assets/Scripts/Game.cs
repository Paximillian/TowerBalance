using UnityEngine;
using System.Collections;

public static class Game
{
    public static bool Lost { get; set; }

    static Game()
    {
        Lost = false;
    }

    public static void Pause()
    {
        foreach (GameObject gObject in GameObject.FindObjectsOfType<GameObject>())
        {
            IPausible pausibleObject = gObject.GetComponent<IPausible>();

            if (pausibleObject != null)
            {
                pausibleObject.Pause();
            }
        }
    }

    public static void Resume()
    {
        foreach (GameObject gObject in GameObject.FindObjectsOfType<GameObject>())
        {
            IPausible pausibleObject = gObject.GetComponent<IPausible>();

            if (pausibleObject != null)
            {
                pausibleObject.Resume();
            }
        }
    }
}
