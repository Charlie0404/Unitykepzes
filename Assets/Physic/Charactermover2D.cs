
using UnityEngine;

class Charactermover2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody; // Az�rt new mert al�h�zza, mert m�r Unitynek van rigidbody
    [SerializeField] float jumpforce;
    [SerializeField] float moveforce;
    [SerializeField] int airJump = 1;



    bool onGround = false; // ((Csak az�rt hogy ki�rja hogy Ground enter vagy exit)) // alapb�l false-ot �r ha nem �rjuk oda sem
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
            rigidbody.velocity = x;   //�gy nem veszti el a v�zszintes mozg�s�t


            // rigidbody.velocity = Vector2.zero;    // �gy is m�k�dik, fenti n�lk�l
            rigidbody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse); // ForceMode be�r�ssal // Csak a rigidbodyra tudunk adni aadd force-t
            jumpCount--;                                                    // impulse = egyszeri, // Velocity Change? (van r�la dia vhol)
                                                                            // Fizika programoz�sn�l legfontosabb fg = AddForce
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal"); // X = direction, ir�ny, Lehet GetKey ekkel is, el�rhet�s�ge, Edit/Project Settings/Input/Horizontal

        rigidbody.AddForce(Vector2.right * x * moveforce, ForceMode2D.Force); //Folytonos azt Force-ban kell FixedUpdate azaz =  ForceMode2D.Force �s FixedUpdate alatt


    }



    void OnCollisionEnter2D(Collision2D collision)   // Oncollison  // void OnCollisionEnter2D(Collision2D collision) sima hitn�l
    {
        onGround = true;                                           // true r�sz csak a bool miatt
        jumpCount = airJump + 1;
        //Debug.Log("Enter: " + collision.collider.name);          // Debug.Log("Hit: " + collision.collider.name); = Itt csak ki�rja hogy hit Ground jelen esetben

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;                                       // false r�sz csak a bool miatt
        //Debug.Log("Exit: " + collision.collider.name);

    }

}
