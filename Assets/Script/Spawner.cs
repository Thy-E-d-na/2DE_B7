using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _heartPref;
    [SerializeField] private float _rate;
    float h, w;
    private void Start()
    {
        h = Camera.main.orthographicSize;
        w = h * Camera.main.aspect;

    }
    private void Update()
    {
        InvokeRepeating(nameof(Spawn),0,Random.Range(5,10));
    }
    void Spawn()
    {
        Vector3 pos = new Vector3(w + 1f, Random.Range(-h, h), 0);
        Instantiate(_heartPref,pos,Quaternion.identity);
    }
}
