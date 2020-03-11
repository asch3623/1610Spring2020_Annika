using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class ListsAndLoops : ScriptableObject
{
    public List<string> stringList;
    public string singleString;

    public void AddToList(string stringObj)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] != stringObj)
            {
                stringList.Add(stringObj);
            }
        }

    }

    public void SortList()
    {
        stringList.Sort();
    }

    public void RemoveFromList(string stringObj)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == stringObj)
            {
                stringList.Remove(stringObj);
            }
        }
    }
    
public void CheckList()
    {
        // looks at each variable in array
        foreach (var obj in stringList)
        {
            if (obj.Contains(singleString))
            {
                Debug.Log(obj);
            }
        }
    }
}
