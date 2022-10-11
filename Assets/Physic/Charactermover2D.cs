
using UnityEngine;

class Charactermover2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody; // Azért new mert aláhúzza, mert már Unitynek van rigidbody
    [SerializeField] float jumpforce;
    [SerializeField] float moveforce;
    [SerializeField] int airJump = 1;



    bool onGround = false; // ((Csak azért hogy kiírja hogy Ground enter vagy exit)) // alapból false-ot ír ha nem írjuk oda sem
    int jumpCount = 0;


    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();

        /*
        GetComponentInParent<Collider2D>();                         
        GetComponentInChildren<SpriteRenderer>();
        */
    }


    void Update()
    {
        bool jumpPress = Input.GetKeyDown(KeyCode.Space);


        if (jumpPress && (onGround || jumpCount > 0))
        {
            Vector2 x = rigidbody.velocity;
            x.y = 0;
            rigidbody.velocity = x;   //Így nem veszti el a vízszintes mozgását


            // rigidbody.velocity = Vector2.zero;    // így is mûködik, fenti nélkül
            rigidbody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse); // ForceMode beírással // Csak a rigidbodyra tudunk adni aadd force-t
            jumpCount--;                                                    // impulse = egyszeri, // Velocity Change? (van róla dia vhol)
                                                                            // Fizika programozásnál legfontosabb fg = AddForce
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal"); // X = direction, irány, Lehet GetKey ekkel is, elérhetõsége, Edit/Project Settings/Input/Horizontal

        rigidbody.AddForce(Vector2.right * x * moveforce, ForceMode2D.Force); //Folytonos azt Force-ban kell FixedUpdate azaz =  ForceMode2D.Force és FixedUpdate alatt


    }



    void OnCollisionEnter2D(Collision2D collision)   // Oncollison  // void OnCollisionEnter2D(Collision2D collision) sima hitnél
    {
        onGround = true;                                           // true rész csak a bool miatt
        jumpCount = airJump + 1;
        //Debug.Log("Enter: " + collision.collider.name);          // Debug.Log("Hit: " + collision.collider.name); = Itt csak kiírja hogy hit Ground jelen esetben

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;                                       // false rész csak a bool miatt
        //Debug.Log("Exit: " + collision.collider.name);

    }

}
