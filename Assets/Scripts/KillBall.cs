using JetBrains.Annotations;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) => collision.gameObject.GetComponent<Ball>()?.Damage();
}
