using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    private void Update()// rotate the object around x and y axes
    {
        transform.localRotation *= Quaternion.AngleAxis(speed * Time.deltaTime , Vector3.up);
    }
}
