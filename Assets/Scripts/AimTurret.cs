using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour
{
    public float turretRotationSpeed = 150;

    internal void Aim(Vector2 pointerPosition)
    {
        var turretDirection = (Vector3)pointerPosition - transform.position;
        var desiredAngle = Mathf.Atan2(turretDirection.y, turretDirection.x) * Mathf.Rad2Deg;
        var rotationSpeed = turretRotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, desiredAngle - 90), rotationSpeed);
    }
}
