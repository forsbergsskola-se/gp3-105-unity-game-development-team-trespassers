using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private bool _playerIsInCar = false;
    private GameObject Player;
    private GameObject carUi;
    private bool playerNear = false;
    private SpriteRenderer spriteRenderer;
    private PlayerMovement playerMovement;

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
    
    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        spriteRenderer = Player.GetComponent<SpriteRenderer>();
    }
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
        spriteRenderer.enabled = true;
        Player.transform.parent = null;
        Player.transform.position = transform.position + new Vector3(0, 1, 0);
        Player.SetActive(true);
        _playerIsInCar = false;
    }
}
