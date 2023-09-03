using UnityEngine;

public class PushBall : MonoBehaviour
{
    private Rigidbody ball;

    [SerializeField] int Power;
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        GetForceBall();
    }

    private void GetForceBall()
    {
        ball.AddForce(Vector3.forward * Power, ForceMode.Impulse);
    }
}
