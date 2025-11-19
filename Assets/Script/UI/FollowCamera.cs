using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;    // El Player
    public Vector3 offset = new Vector3(0f, 5f, -8f);
    
    public bool lockX = false;
    public bool lockY = true;   // Por defecto bloqueamos la altura
    public bool lockZ = false;

    private Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
    }

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPos = target.position + offset;

        if (lockX) desiredPos.x = initialPos.x;
        if (lockY) desiredPos.y = initialPos.y;
        if (lockZ) desiredPos.z = initialPos.z;

        transform.position = desiredPos;
        transform.LookAt(target);
    }
}
