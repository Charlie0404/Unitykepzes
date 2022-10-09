using UnityEngine;

class StepMover : MonoBehaviour
{


    void Update()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);

        if (up)
            transform.position += new Vector3(0, 1, 0);
        if (down)
            transform.position +=  Vector3.down;   // ez ugyanaz mint a fenti 
        if (right)
            transform.position +=  Vector3.right;
        if (left)
            transform.position +=  Vector3.left;



    }
}
