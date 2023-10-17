using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private bool _playerIsInCar = false;
    public GameObject Player;

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
