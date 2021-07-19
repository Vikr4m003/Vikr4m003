using UnityEngine;

public class jump : MonoBehaviour
{
    public Vector2 JumpForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
    }
}
