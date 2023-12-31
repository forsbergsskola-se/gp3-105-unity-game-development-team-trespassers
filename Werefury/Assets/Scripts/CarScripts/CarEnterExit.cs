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
        [SerializeField] private HP Hp;
        [SerializeField] private SpriteRenderer spriteRenderer;
        private PlayerMovement playerMovement;
        private Collider playerCollider;
        private AudioSource audiosource;
    
        private void Start()
        {
            audiosource = this.GetComponent<AudioSource>();
            Player = GameObject.FindWithTag("Player");
            playerCollider = Player.GetComponentInChildren<Collider>();
        }
        public void Update()
        {
            
            if (Hp.carDeath == true)
            {
                Debug.Log("We try to leave");
                ExitCar();
            }
            
            if (Input.GetKeyDown(KeyCode.E) && !_playerIsInCar && playerNear)
            {
                EnterCar();
            }
            else if (Input.GetKeyDown(KeyCode.E) && _playerIsInCar)
            {
                ExitCar();
            }
        }

        public void FixedUpdate()
        {
            if (_playerIsInCar)
            {
                Player.transform.localPosition = new Vector3(0, 1, 0);
            }
        }

        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("IN");
                playerNear = true;
            }
        }
    
        public void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerNear = false;
                Debug.Log("OUt");
            }
        }
    
        void EnterCar()
        {
            audiosource.Play();
            gameObject.tag = "Player";
            Player.tag = "Untagged";
            spriteRenderer.enabled = false;
            playerCollider.enabled = false;
            Player.transform.parent = transform;
            Player.transform.localPosition = new Vector3(0, 1, 0);
            _playerIsInCar = true;

        }

        public void ExitCar()
        {
            audiosource.Pause();
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
