using UnityEngine;

public class CubeTwoScript : MonoBehaviour
{
    private float _moveSpeed = 1.0f;
    private float _rotateSpeed = 20f;
    private float _changeSize = 0.1f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * (_moveSpeed * Time.deltaTime));
        
        transform.Rotate(Vector3.up * (_rotateSpeed * Time.deltaTime), Space.Self);
        
        transform.localScale += new Vector3(_changeSize,  _changeSize, _changeSize) * Time.deltaTime;
    }
}
