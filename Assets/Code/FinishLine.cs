using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float LoadDelay = 0.5f;
    [SerializeField] ParticleSystem FinishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            FinishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", LoadDelay); 
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
