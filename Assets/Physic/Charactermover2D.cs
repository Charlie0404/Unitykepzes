using UnityEngine;

class CharacterMover2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpForce;
    [SerializeField] float moveForce;
    [SerializeField] float moveSpeed;
    [SerializeField] int airJumps = 1;

    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask canJumpLayer;

    bool onGround = false;
    int jumpCounts = 0;

    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool jumpPress = Input.GetKeyDown(KeyCode.Space);

        if (jumpPress && jumpCounts > 0)
        {
            Vector2 v = rigidbody.velocity;
            v.y = 0;
            rigidbody.velocity = v;

            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpCounts--;
        }
    }

    void FixedUpdate()
    {
        float direction = Input.GetAxis("Horizontal");

        if (onGround)
        {
            // F?ld?n nincs tehetetlens?g?nk:
            Vector2 v = rigidbody.velocity;
            v.x = direction * moveSpeed;
            rigidbody.velocity = v;
        }
        else
        {
            // Leveg?ben tehetetlen mozg?s:
            rigidbody.AddForce(Vector2.right * direction * moveForce, ForceMode2D.Force);

            // Maximaliz?lom a vizszintes sebess?get:
            Vector2 v = rigidbody.velocity;
            float dir = Mathf.Sign(v.x);
            float horizontalSpeed = Mathf.Abs(v.x);
            v.x = Mathf.Min(horizontalSpeed, moveSpeed) * dir;
            rigidbody.velocity = v;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        int layer = collision.gameObject.layer; //Lek?rem a layert annak amivel ?tk?ztem

        if (groundLayer.Contains (layer))   //Ha tartalmazza a groundLayer mask a layer-t
        {
            onGround = true;

            jumpCounts = 0;

        }

        if (canJumpLayer.Contains(layer))
            jumpCounts = airJumps + 1;

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
        // Debug.Log("Exit: " + collision.collider.name);
    }
}