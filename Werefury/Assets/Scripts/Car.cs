using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private bool _playerIsInCar = false;
    private GameObject player;

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
        player.SetActive(false);
        player.transform.parent = transform;
        player.transform.localPosition = new Vector3(0, 1, 0);
        _playerIsInCar = true;
    }

    void ExitCar()
    {
        player.transform.parent = null;
        player.transform.position = transform.position + new Vector3(0, 1, 0);
        player.SetActive(true);
        _playerIsInCar = false;
    }
}
