using UnityEngine;

public class Timer : MonoBehaviour
{
    public float CurrentTime { get; private set; }

    void Start()
    {
        SetNull();
    }

    void Update()
    {
        CurrentTime += Time.deltaTime;
    }

    public void SetNull()
    {
        CurrentTime = 0f;
    }
}
