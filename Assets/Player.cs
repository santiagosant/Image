using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _characterController;
    public float _moveSpeed = 10000;
    public ParticleSystem chispas;
    public float Rotationspeed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal");
       
        _characterController.SimpleMove(moveDir * _moveSpeed * Time.deltaTime);
    
        if (Input.GetKeyDown("space"))
        {
            chispas.Play();
        }

        // if (Input.anyKey())
        // {
        //     chispas.SetActive(false);
        // }

        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * Rotationspeed, 0));

    }
}
