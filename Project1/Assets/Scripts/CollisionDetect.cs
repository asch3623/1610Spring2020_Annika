
using DataTypes;
using UnityEngine;


public class CollisionDetect : MonoBehaviour
{
   public BoolData groundCheck;
   public LayerMask ground;
   public bool isGrounded;

   void Update()
   {
      isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
         new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f), ground);
      
      
      if (isGrounded)
      {
         collisionCheck.value = true;
      }
      else
      {
         collisionCheck.value = false;
      }
   }
}
