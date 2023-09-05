using UnityEngine;

public class PushBall : MonoBehaviour
{
    private Rigidbody ball;

    [SerializeField] int Power;         // ����, ����������� � �������
    [SerializeField] Vector3 Vector;    // ������ ����������� ����
    private Timer timer;                // ������, ������������� ����� ���������� ����

    void Start()
    {
        ball = GetComponent<Rigidbody>();
        timer = GetComponent<Timer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            timer.SetNull();
        if (Input.GetKey(KeyCode.Space))
            AddForce();
    }

    private void AddForce()
    {
        ball.AddForce(Vector * Power * timer.CurrentTime, ForceMode.Force);
    }
}
