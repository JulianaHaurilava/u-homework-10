using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody ball;

    [SerializeField] int Power;         // сила, приложенная к объекту
    [SerializeField] Vector3 Vector;    // вектор направления силы
    void Start()
    {
        ball = GetComponent<Rigidbody>();

        // сила прикладывается в начале игры
        AddImpulse();
    }

    private void AddImpulse()
    {
        ball.AddForce(Vector * Power, ForceMode.Impulse);
    }
}
