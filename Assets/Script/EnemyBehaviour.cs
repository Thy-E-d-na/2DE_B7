using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _birdPref;
    [SerializeField] private GameObject _gOverPnl;
    [SerializeField] private PlayerMove _player;
    [SerializeField] private float _rate;
    float h, w;
    private void Start()
    {
        h = Camera.main.orthographicSize;
        w = h * Camera.main.aspect * 2;
        StartCoroutine(Spawn());
    }
   
    IEnumerator Spawn()
    {
        while (true)
        {
            float y = h - 3;
            Vector3 pos = new Vector3(w + 1f, Random.Range(-h, h), 0);
            Instantiate(_birdPref, pos, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(5, 10));
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            _gOverPnl.SetActive(true);
        }
    }
}
