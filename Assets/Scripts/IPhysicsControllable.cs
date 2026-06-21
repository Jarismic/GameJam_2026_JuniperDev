using UnityEngine;

public interface IPhysicsControllable
{
    public void ReceiveHit(Vector3 forceOrigin, float hitForce);
}
