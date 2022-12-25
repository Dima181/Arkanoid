using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float Speed;

    // -4.434   4.434
    void Update()
    {
        transform.Translate(Speed * Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -4.434f, 4.434f), transform.position.y);
    }
}
