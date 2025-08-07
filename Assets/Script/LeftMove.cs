using UnityEngine;

public class LeftMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    float LeftEdge;
    private void Start()
    {
      
        LeftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
        if(transform.position.x - 1f < LeftEdge)
        { 
            Destroy(gameObject); 
        }
    }
    

}
