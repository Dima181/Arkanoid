using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField][Min(1)] private int Health;
    [SerializeField] private List<Sprite> Sprite;
    public UnityEvent<Block> BlockDestroyed;

    public void Start() => ResetSprite();
    private void ResetSprite() => GetComponent<SpriteRenderer>().sprite = Sprite[Health - 1];
    public void Damage()
    {
        Health -= 1;
        if (Health > 0)
        {
            ResetSprite();
        }
        else
        {
            BlockDestroyed?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
