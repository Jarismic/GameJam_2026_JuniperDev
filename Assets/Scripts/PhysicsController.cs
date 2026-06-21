using System;
using UnityEngine;

public class PhysicsController : MonoBehaviour, IPhysicsControllable
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float hitForceMultiplier;

    public void ReceiveHit(Vector3 forceOrigin, float hitForce)
    {
        
    }
}
