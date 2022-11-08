
using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed = 10;                  //offset , speed
    //[SerializeField] Vector3 velocity;//
    [SerializeField] float angularSpeed = 180;
    

    [SerializeField] Animator animator;


    void Update()
    {
        /* 

         Vector3 position = transform.position;
         position.x = velocity * Time.deltaTime;    //offset , Time.deltaTime  -  eltelt idõ - lassabb gépen nagyobb lesz

         */


        bool up1 = Input.GetKey(KeyCode.UpArrow);                //Input.GetKey(KeyCode.W)
        bool down1 = Input.GetKey(KeyCode.DownArrow);
        bool left1 = Input.GetKey(KeyCode.LeftArrow);
        bool right1 = Input.GetKey(KeyCode.RightArrow);

        bool up2 = Input.GetKey(KeyCode.W);
        bool down2 = Input.GetKey(KeyCode.S);
        bool left2 = Input.GetKey(KeyCode.A);
        bool right2 = Input.GetKey(KeyCode.D);




        float x = 0;
        if (right1 || right2)
            x = 1;                  // += else nélkül
        else if (left1 || left2)
            x = -1;

        float y = 0;
        if (up1 || up2)                     //  -= else nélkül
            y = 1;
        else if (down1 || down2)
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

        bool isRunning = velocity != Vector3.zero;

        animator.SetBool("isRunning", isRunning);

        if (isRunning)
        {
             
            Quaternion targetRot = Quaternion.LookRotation(velocity);   // Merre nézzen

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, angularSpeed * Time.deltaTime);



        }
            


    }
    public void StepDown()
    {

        Debug.Log("Step");
    
    }


}
