using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torque = 3f;
    Rigidbody2D rb2d;
    [SerializeField] SurfaceEffector2D surfaceEffecter2D;
    [SerializeField] float BootSpeed = 30f;
    [SerializeField] float BaseSpeed = 10f;
    bool CanMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffecter2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
        RotatePlayer();
        BootsMetod();
        }

    }
    public void DisableController()
    {
        CanMove = false;
    }
    void BootsMetod()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffecter2D.speed = BootSpeed;
        }
        else
        {
            surfaceEffecter2D.speed = BaseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torque);
        }
    }
}
