using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _heartPref;
    [SerializeField] private GameObject _birdPref;
    [SerializeField] private float _rate;
    float h, w;
    private void Start()
    {
        h = Camera.main.orthographicSize;
        w = h * Camera.main.aspect * 2;
        StartCoroutine(Spawn(_heartPref));
        StartCoroutine(Spawn(_birdPref));
    }

    IEnumerator Spawn(GameObject x)
    {
        while (true)
        {
            float y = h - 3;
            Vector3 pos = new Vector3(w + 1f, Random.Range(-h , h), 0);
            Instantiate(x, pos, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(5, 10));
        }
        
    }
}
