using UnityEngine;

public class Bird : MonoBehaviour
{
    private bool isDead = false;
    // callar rigidbody från gameobject
    private Rigidbody2D rb;

    // forcen i FLAPPEN
    public float upForce = 200f;

    void Start()
    {
        // i startup hämta rigidbody från objektet
        rb = GetComponent<Rigidbody2D>();
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
            }
        }
    }
}
