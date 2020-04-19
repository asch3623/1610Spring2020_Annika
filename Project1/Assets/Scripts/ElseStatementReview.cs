using UnityEngine;

public class ElseStatementReview : MonoBehaviour
{
   
   int startingInt = 1;
   int b = 3;
   int c = 1;
   int d = 4;
   
    void Start()
    {
   if (b + c == d)
   {
       Debug.Log("This is correct.");
   }     
   
   else if (startingInt != 0)
   {
       Debug.Log("Starting Int is not 0");
   }
    }
}
