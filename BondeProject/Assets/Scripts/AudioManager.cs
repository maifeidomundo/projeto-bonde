using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSFX audioSFX;

    void Start() {
        if (instance == null) {
            instance = this;
        }
    }



    public void PlaySoundFail(GameObject obj) {
        AudioSource.PlayClipAtPoint(audioSFX.fail, obj.transform.position);
    }
}
