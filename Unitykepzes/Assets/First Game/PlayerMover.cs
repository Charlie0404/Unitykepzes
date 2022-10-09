
using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;                  //offset , speed
    //[SerializeField] Vector3 velocity;//



    void Update()
    {
        /* 

         Vector3 position = transform.position;
         position.x = velocity * Time.deltaTime;    //offset , Time.deltaTime  -  eltelt idõ - lassabb gépen nagyobb lesz

         */


        bool up = Input.GetKey(KeyCode.UpArrow);                //Input.GetKey(KeyCode.W)
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);

        float x = 0;
        if (right)
            x = 1;                  // += else nélkül
        else if (left)
            x = -1;

        float y = 0;
        if (up)                     //  -= else nélkül
            y = 1;
        else if (down)
            y = -1;
        /* 
        float x = 0;
        if (right)
        x = 1; 
        */



        Vector3 velocity = new Vector3(x, 0, y);
        velocity.Normalize(); 
        velocity *= speed;


        transform.position += velocity * Time.deltaTime;



        if(velocity != Vector3.zero)

            transform.rotation = Quaternion.LookRotation(velocity);   // Merre nézzen


    }

}
