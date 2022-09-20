
using UnityEngine;

class NewBehaviourScript : MonoBehaviour
{

    void OnValidate()
    {
        Vector2 vector = new Vector2(2,5);

        float vx = vector.x;
        float vy = vector.y;

        vector.x = vy;
        vector.y = vx;

        Vector3 vector3 = new Vector3(1, 2, 4);

        vector3.z *= 2;

        Vector3 myleft = Vector3.left; // (-1,0,0)

        Vector3 v1 = new Vector3(1, 6, 4), v2 = new Vector3(3, 7, 8);


        Vector3 sum = v1 + v2;  // 4 13 12



        //valami.magnitude / hossz
        // float m = valami.magnitude;


        Vector3 v1n = v1.normalized;  //normalizálás
        Debug.Log(v1n.magnitude);



        float d1 = (v1 - v2).magnitude;
        float d2 = Vector3.Distance(v1, v2);















    }


}
