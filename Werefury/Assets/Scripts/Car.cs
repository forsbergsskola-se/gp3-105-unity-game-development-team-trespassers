using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private bool _playerIsInCar = false;
<<<<<<< HEAD
    public GameObject Player;
=======
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
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
           
        }
    }
>>>>>>> parent of 49bf192 (Revert "Yup! Merges!")

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !_playerIsInCar)
        {
            EnterCar();
        }
        else if (Input.GetKeyDown(KeyCode.E) && _playerIsInCar)
        {
            ExitCar();
        }
    }

    void EnterCar()
    {
        gameObject.tag = "Player";
        Player.SetActive(false);
        Player.transform.parent = transform;
        Player.transform.localPosition = new Vector3(0, 1, 0);
        _playerIsInCar = true;
    }
    void ExitCar()
    {
        gameObject.tag = "Untagged";
        Player.transform.parent = null;
        Player.transform.position = transform.position + new Vector3(0, 1, 0);
        Player.SetActive(true);
        _playerIsInCar = false;
    }
}
