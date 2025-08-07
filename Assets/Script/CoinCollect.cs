using UnityEngine;


public class CoinCollect : MonoBehaviour
{
    private CoinManager _manager;
    private void Start()
    {
        _manager = FindFirstObjectByType<CoinManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _manager.AddCoin();
            Destroy(gameObject);
        }
    }
}
