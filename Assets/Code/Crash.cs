using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float LoadDelay = 0.5f;
    [SerializeField] ParticleSystem CrashEffect;
    [SerializeField] AudioClip crash;
    private int Flag = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Ground")
      {
            if(Flag == 0)
            {
                CrashEffect.Play();
                Flag++;
            }
            FindObjectOfType<PlayerController>().DisableController();
            GetComponent<AudioSource>().PlayOneShot(crash);
            Invoke("ReloadScene", LoadDelay);
      }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
