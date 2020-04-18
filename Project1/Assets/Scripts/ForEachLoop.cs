using UnityEngine;

public class ForEachLoo : MonoBehaviour
{
    public int[] scores;
    public string[] names;
    int average;
    string existingNames;
    void Start()
    {
        

        foreach (int score in scores)
        {
            average = average + score;
        }
        
        //for (int i = 0; i < scores.Length; i++){
      //  average = average +scores[i];
//
        print("the average is " + average / scores.Length);

      
        for (int i = 0; i < names.Length; i++)
        {
            existingNames += names[i] + " ";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
