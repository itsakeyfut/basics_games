using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        float thresholdLimit = 8f;

        if (transform.position.y > thresholdLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
