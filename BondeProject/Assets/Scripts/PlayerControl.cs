using System.Collections;
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
          
         AudioManager.instance.PlaySoundFail(gameObject);
         Destroy(gameObject);
            
            
        
        }

    }


 
        

        
        
   


















    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
            //projectile.transform.SetParent(parent.transform);
            projectile.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;
        }
    }
}
