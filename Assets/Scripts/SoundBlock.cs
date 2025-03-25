using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class SoundBlock : MonoBehaviour
{
    public EventReference blockSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.instance.PlayOneShot(blockSound, transform.position);
    }
}
