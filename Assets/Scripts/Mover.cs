using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _moveSpeed = 1.0f;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * (_moveSpeed * Time.deltaTime), Space.Self);
    }
}
