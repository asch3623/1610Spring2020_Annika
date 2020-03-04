using UnityEngine;

namespace DataTypes
{
    [CreateAssetMenu]
    public class IntData : ScriptableObject
    {
        public int value = 0;

        public void ChangeValue(int number)
        {
            value += number;
        }
    }
}
