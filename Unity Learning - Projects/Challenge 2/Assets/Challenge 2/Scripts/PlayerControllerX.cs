using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 1.0f;
    private float lastspawnTime=0f;

    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastspawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastspawnTime = Time.time + cooldown;   
        }
    }
}
