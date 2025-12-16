using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class AyaneScript : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Transform _OriantatitonTransform;
    [Header("Movement Settings")]
    [SerializeField] private float _PlayerSpeed;
    [SerializeField] private KeyCode _MovementKey;

    private float horizontalİnput , verticalİnput;
    private Rigidbody _playerRigidbody;

    void Awake()
    {
        _playerRigidbody.GetComponent<Rigidbody>();
        _playerRigidbody.freezeRotation = true;
    }

    private void setİnputs()
    {
        horizontalİnput = Input.GetAxisRaw("Horizontal");
        verticalİnput = Input.GetAxisRaw("Vertical");
    }

    private void Update()
    {
    }

}
