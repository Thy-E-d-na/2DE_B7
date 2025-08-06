using UnityEngine;

public class LeftMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    Vector3 LeftEdge;
    private void Start()
    {
      
        LeftEdge = Camera.main.ScreenToViewportPoint(Vector3.zero);
    }
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
        if(transform.position.x - 1f < LeftEdge.x)
        { Destroy(gameObject); }
    }
 
}
