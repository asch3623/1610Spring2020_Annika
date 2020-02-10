using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "OU2095";
    public bool canRun = true;
    void Start()
    {
        if (a+b != c)
        {
            print("That's true broski");
        }

        if (password != "OU2095")
        {
            print("That's the correct password my guy");
        }

        if (!canRun)
        {
            print("we not running");
        }
        
    }
    
    void Update()
    {
        
    }
}
