using PlayerScripts;
using UnityEngine;

namespace CarScripts
{
    public class Car : MonoBehaviour
    {
        public bool _playerIsInCar = false;
        private GameObject Player;
        private GameObject carUi;
        private bool playerNear = false;
        [SerializeField] private SpriteRenderer spriteRenderer;
        private PlayerMovement playerMovement;
        private Collider playerCollider;
    
        private void Start()
        {
            Player = GameObject.FindWithTag("Player");
            playerCollider = Player.GetComponentInChildren<Collider>();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && !_playerIsInCar && playerNear)
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
            if (_playerIsInCar)
            {
                Player.transform.localPosition = new Vector3(0, 1, 0);
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("IN");
                playerNear = true;
            }
        }
    
        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerNear = false;
                Debug.Log("OUt");
            }
        }
    
        void EnterCar()
        {
            gameObject.tag = "Player";
            Player.tag = "Untagged";
            spriteRenderer.enabled = false;
            playerCollider.enabled = false;
            Player.transform.parent = transform;
            Player.transform.localPosition = new Vector3(0, 1, 0);
            _playerIsInCar = true;

        }

        void ExitCar()
        {
            gameObject.tag = "Untagged";
            Player.tag = "Player";
            spriteRenderer.enabled = true;
            playerCollider.enabled = true;
            Player.transform.parent = null;
            Player.transform.position = transform.position + new Vector3(0, 1, 0);
            Player.SetActive(true);
            _playerIsInCar = false;
        }
    }
}
