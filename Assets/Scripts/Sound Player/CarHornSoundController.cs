using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class CarHornSoundController : MonoBehaviour, ISoundListener
{
    #region ISOUND_PROPERTIES

    public AudioClip Clip => _clip;
    public AudioSource Source => _source;

    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioSource _source;
    
    #endregion
    
    #region UNITY_EVETNS
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) Play();
        if(Input.GetKeyDown(KeyCode.Alpha2)) Stop();
        if(Input.GetKeyDown(KeyCode.Alpha3)) PlayOneShot();
    }
    #endregion

    #region ISOUND_METHODS
    public void Init()
    {
        _source = GetComponent<AudioSource>();
        _source.clip = Clip;
    }

    public void Play() => _source.Play();
    

    public void Stop() => _source.Stop();

    public void PlayOneShot() => _source.PlayOneShot(Clip);
    

    #endregion
    
}
