using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    [SerializeField] private float _changeSize;
    
    void Update()
    {
        transform.localScale += new Vector3(_changeSize,  _changeSize, _changeSize) * Time.deltaTime;
    }
}
