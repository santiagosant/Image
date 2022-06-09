using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _characterController;
    public float _moveSpeed = 50f;
    public ParticleSystem chispas;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal");
       
        _characterController.SimpleMove(moveDir * _moveSpeed*Time.deltaTime);
    
        if (Input.GetKeyDown("space"))
        {
            chispas.Play();
        }

        // if (Input.anyKey())
        // {
        //     chispas.SetActive(false);
        // }
    
    }
}
