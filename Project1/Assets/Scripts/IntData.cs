using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
   public int value = 2;

   public void ChangeValue(int number)
   {
      value += number;
      
   }
   
}
