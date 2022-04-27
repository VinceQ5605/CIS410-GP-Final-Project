using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [Range(.1f,20f)]
    public float size;
    [Range(0f, 30f)]
    public float knockBackForce;
    //public int damage;

    private void OnEnable()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, size);
        foreach (Collider hitCollider in hitColliders)
        {
            GameObject gameObject = hitCollider.gameObject;
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            Vector3 direction = gameObject.transform.position - transform.position;

            direction.Normalize();
            gameObject.SendMessage("Hit", knockBackForce * direction);
        }
        this.gameObject.SetActive(false);
    }
}
