using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Animator myAnimator;
    public float direccion;
    public float speed;
    // Start is called before the first frame update
    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direccion = transform.localScale.x;
        transform.Translate(new Vector2(direccion * speed * Time.deltaTime,0)); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouchingLayers(LayerMask.GetMask("gruond")))
        {
            Destroy(this.gameObject);
            myAnimator.SetTrigger("Explosion");
        }
    }
}
