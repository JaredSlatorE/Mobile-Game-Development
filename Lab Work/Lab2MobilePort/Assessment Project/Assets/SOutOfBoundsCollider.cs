using UnityEngine;

public class SOutOfBoundsCollider : MonoBehaviour
{


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(0,0);
        }
    }
}
