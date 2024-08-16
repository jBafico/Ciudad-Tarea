using UnityEngine;

public interface ISoundListener
{
    AudioClip Clip { get; }
    AudioSource Source { get; }

    void Init();

    void Play();
    void Stop();

    void PlayOneShot();
}
