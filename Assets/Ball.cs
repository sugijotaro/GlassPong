using UnityEngine;
using System.Collections;
using System;

public class Ball : MonoBehaviour
{
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    public float powerPerPixel;
    public float pawaaaa;
    private Vector3 position; 

    void Start()
	{
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,
                                        Input.mousePosition.z);
            print(touchStartPos); 
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            touchEndPos = new Vector3(Input.mousePosition.x,
                                      Input.mousePosition.y,
                                      Input.mousePosition.z);
            print(touchEndPos);

            GetComponent<Rigidbody>().isKinematic = false;

            GetComponent<Rigidbody>().AddForce(new Vector3(
                (float)((touchEndPos.x - touchStartPos.x)*0.4* pawaaaa),
                (float)(((float)Math.Sqrt(Math.Pow(touchEndPos.x - touchStartPos.x,2)+Math.Pow(touchEndPos.y - touchStartPos.y , 2))) * powerPerPixel* pawaaaa),
                (touchEndPos.y - touchStartPos.y)* pawaaaa
            ));

             
        }

         if (Input.GetKeyDown(KeyCode.R ))
        {
            print("pressed R");
            GetComponent<Rigidbody>().AddForce(new Vector3( 0,0,0 ));
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = new Vector3(0, 0.8f, -9.3f);
        }
    }

//    void GetDirection()
//    {
//        float directionX = touchEndPos.x - touchStartPos.x;
//        float directionY = touchEndPos.y - touchStartPos.y;
//        string Direction;

//        if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
//        {
//            if (30 < directionX)
//            {
//                //右向きにフリック
//                Direction = "right";
//            }
//            else if (-30 > directionX)
//            {
//                //左向きにフリック
//                Direction = "left";
//            }
//           }
//    else if (Mathf.Abs(directionX)<Mathf.Abs(directionY) {
//            if (30 < directionY){
//                //上向きにフリック
//                Direction = "up";
//            }else if (-30 > directionY)
//{
//    //下向きのフリック
//    Direction = "down";
//}
//    }else
//{
//    //タッチを検出
//    Direction = "touch";
//}
//    }

     
      

}