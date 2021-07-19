using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed);

        if (transform.position.x < -15)
            transform.position += Vector3.right * 30;
    }
}
