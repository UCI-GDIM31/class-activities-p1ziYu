using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private Transform _playerTransform;
    public void EnableChase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }
    public void DisableChase()
    {
        enabled = false;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            speed * Time.deltaTime
        );
    }
}
