using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControle : MonoBehaviour
{
    private Animator anim;
    //public SelectorGuns gunSelector;
   // public Transform cam;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Rotate(0,250 * Input.GetAxis("Horizontal") * Time.deltaTime,0);

        anim.SetFloat("move", Input.GetAxis("Vertical"));
        //anim.SetBool("shoot", gunSelector.guns[gunSelector.nrGun].inShoot);
    }
}
