using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody ball;

    [SerializeField] int Power;
    [SerializeField] Vector3 Vector;
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        AddImpulse();
    }

    private void AddImpulse()
    {
        ball.AddForce(Vector * Power, ForceMode.Impulse);
    }
}
