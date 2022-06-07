using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerRun : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform target;
    private bool scared = false;
    private Rigidbody2D deerRigid;
    // Start is called before the first frame update
    private void Awake()
    {
        deerRigid = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            scared = true;
        }
    }

    private void Update()
    {
        if (scared == true)
        {
            Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;
            deerRigid.AddForce(direction * speed);
        }
    }
}
