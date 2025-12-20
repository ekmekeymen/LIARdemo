using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    [SerializeField] private Transform _OriantationTransform;

    private float _Horizontalİnput, _Verticalİnput;
    private Rigidbody _PlayerRigidbody;
    private Vector3 _MovementDirection;

    void Awake()
    {
        _PlayerRigidbody = GetComponent<Rigidbody>();
        _PlayerRigidbody.freezeRotation = true;
    }

    void Update()
    {
        Setİnputs();
    }

    private void Setİnputs()
    {
        _Horizontalİnput = Input.GetAxisRaw("Horizontal");
        _Verticalİnput = Input.GetAxisRaw("Vertical");
    }

    private void PlayerMovement()
    {
        _MovementDirection = _OriantationTransform.forward * _Verticalİnput + _OriantationTransform.right * _Horizontalİnput;

        _PlayerRigidbody.AddForce(_MovementDirection * 10f, ForceMode.Force);
    }
}
