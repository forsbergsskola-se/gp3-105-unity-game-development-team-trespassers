using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private bool _playerIsInCar = false;
<<<<<<< HEAD
    private GameObject Player;
    private GameObject carUi;
    private bool playerNear = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        spriteRenderer = Player.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("IN");
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            Debug.Log("OUt");
        }
    }
=======
    public GameObject Player;
>>>>>>> 1c4ec010d706ece019e3484096a75e746cf6ecc6

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !_playerIsInCar && !playerNear)
        {
            EnterCar();
        }
        else if (Input.GetKeyDown(KeyCode.E) && _playerIsInCar)
        {
            ExitCar();
        }
    }

    private void FixedUpdate()
    {
        //INPUT TRANSFORM LOGIC FOR PLAYER TO FOLLOW CORRECTLY
    }

    void EnterCar()
    {
        gameObject.tag = "Player";
        Player.tag = "Untagged";
        spriteRenderer.enabled = false;
        Player.transform.parent = transform;
        Player.transform.localPosition = new Vector3(0, 1, 0);
        _playerIsInCar = true;
    }
    void ExitCar()
    {
        gameObject.tag = "Untagged";
        Player.tag = "Player";
        Player.transform.parent = null;
        Player.transform.position = transform.position + new Vector3(0, 1, 0);
        spriteRenderer.enabled = true;
        _playerIsInCar = false;
    }
}
