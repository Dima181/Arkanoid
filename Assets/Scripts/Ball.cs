using UnityEngine.Events;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public UnityEvent<Ball> BallDestroyed;
    void Start() => gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(2, 5), Random.Range(2, 5));
    void OnCollisionEnter2D(Collision2D collision) => collision.gameObject.GetComponent<Block>()?.Damage();
    public void Damage()
    {
        BallDestroyed?.Invoke(this);
        Destroy(gameObject);
    }
}
