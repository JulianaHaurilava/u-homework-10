using UnityEngine;

public class PushBall : MonoBehaviour
{
    private Rigidbody ball;

    [SerializeField] int Power;         // сила, приложенная к объекту
    [SerializeField] Vector3 Vector;    // вектор направления силы
    private Timer timer;                // таймер, отсчитывающий время приложения силы

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
