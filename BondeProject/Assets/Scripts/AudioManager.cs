using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
public static AudioManager instance;
public AudioSFX audioSFX;





    public void PlaySoundFail(GameObject obj) {
        AudioSource.PlayClipAtPoint(audioSFX.fail, obj.transform.position);
    }
}
