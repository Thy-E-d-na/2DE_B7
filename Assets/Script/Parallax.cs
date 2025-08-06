using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] float _moveSpeed;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(_moveSpeed * Time.deltaTime,0);
    }
}
