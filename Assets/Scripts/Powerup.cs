using UnityEngine;

public class Powerup : MonoBehaviour
{
    private float _speed = 3.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float verticalLimit = -4.5f;
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < verticalLimit)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            Player player = other.transform.GetComponent<Player>();
            player.ActivateTripleShot();
        }
    }
}
