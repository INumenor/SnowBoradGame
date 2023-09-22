using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem DustEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Level Sprite Shape")
        {
            DustEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
            DustEffect.Stop();
    }
}
