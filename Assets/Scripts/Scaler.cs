using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _changeSize;
    
    private void Update()
    {
        transform.localScale += new Vector3(_changeSize,  _changeSize, _changeSize) * Time.deltaTime;
    }
}
