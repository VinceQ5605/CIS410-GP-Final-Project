using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeController : MonoBehaviour
{
    public float lifeTime = 5f;
    public GameObject explosion;
    public float minY = -20f;

    void Start()
    {

    }


    void Update()
    {
        StatusCheck();
    }

    void StatusCheck()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime < 0)
        {
            Destroy();
        }

        if (transform.position.y < minY)
        {
            Destroy();
        }

        void Destroy()
        {
            Instantiate(explosion, transform.position, transform.rotation);
            this.gameObject.SetActive(false);
        }
    }
}
