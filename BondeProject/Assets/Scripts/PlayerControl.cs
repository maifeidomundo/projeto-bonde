﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPoint;
    public float velocity = 100f;





    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemies"))
        {
            Camera.main.GetComponentInChildren<AudioSource>().mute = true;
            AudioManager.instance.PlaySoundFail(gameObject);
            Destroy(gameObject);
            LevelManager.instance.ShowGameOverPanel(); 


        }

        if (other.gameObject.CompareTag("Gift"))
        {
            Camera.main.GetComponentInChildren<AudioSource>().mute = true;
            AudioManager.instance.PlaySoundLevelcomplete(gameObject);
            Destroy(gameObject);
            LevelManager.instance.ShowLevelCompletePanel();


        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //GameObject projectile = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
            //projectile.transform.SetParent(parent.transform);
            //projectile.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;
        }
    }

    public void Atirar() {
        GameObject projectile = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;       
    }
}
