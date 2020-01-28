using UnityEngine;

public class Bird : MonoBehaviour
{
    private bool isDead = false;
    // callar rigidbody från gameobject
    private Rigidbody2D rb;
    // callar animator från gameobject
    private Animator anim;

    // forcen i FLAPPEN
    public float upForce = 200f;

    void Start()
    {
        // i startup hämta från objektet
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // inge FLAPS om du är död
        if (isDead == false)
        {
            // 0 LMB 1 RMB
            if (Input.GetMouseButtonDown(0))
            {
                // sätt rbs velocity till 0 så det är samma FLAPP varje gång
                rb.velocity = Vector2.zero;
                // adda forcen uppåt
                rb.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
    }

    // om collision med någon rigidbody
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        anim.SetTrigger("Die");
    }
}
