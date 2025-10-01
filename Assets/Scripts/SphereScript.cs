using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private float _moveSpeed = 1.0f;
    
    void Update()
    {
        transform.position += new Vector3(0, 0, _moveSpeed * Time.deltaTime);
    }
}
