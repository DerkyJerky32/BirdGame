using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MainBird  bird = collision.collider.GetComponent<MainBird>();

        if (bird != null)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);            
            Destroy(gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();

        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < - 0.5)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

}
