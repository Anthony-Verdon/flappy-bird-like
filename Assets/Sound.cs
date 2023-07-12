using UnityEngine.Audio;
using UnityEngine;

/*
It allow to have a list of elements (we can modify number of elements) in the Inspector,
and we can modify every elements of the list, to modify the attributes.
Serialization is a way to stock informations.
Not compatible with inheritance of MonoBehaviour.
*/
[System.Serializable]

public class Sound
{
    public AudioClip clip;
    public string name;

    //Range add a scrollbar, going to X to Y (here X = 0.0f and Y = 1.0f) on the Inspector, modifying volume value
    [Range(0.0f, 1.0f)]
    public float volume;

    [Range(0.1f, 3.0f)]
    public float pitch;

    //A bool is checkbox on the Inspector
    public bool loop;

    //this tag hide this attribute in the Inspector
    [HideInInspector]
    public AudioSource source;
}

