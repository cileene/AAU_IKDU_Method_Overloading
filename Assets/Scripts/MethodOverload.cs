using UnityEngine;

public class MethodOverload : MonoBehaviour
{
    // The first GettingOlder method
    public int GettingOlder(int currentAge)
    {
        currentAge += 1;

        Debug.Log($"You are aging rapidly and next year you'll be {currentAge} years old. Yikes...");

        return currentAge;
    }

    // The second GettingOlder method
    public int GettingOlder(int currentAge, int collegeYears)
    {
        currentAge += collegeYears;

        // Yes this string is a bit long.
        Debug.Log($"You are aging rapidly and now you chose to go to college for {collegeYears} more years?! Then you will be {currentAge} years old. And without a pension plan.");

        return currentAge;
    }

    void Start()
    {
        // Declaring my age
        int currentAge = 33;
        currentAge = GettingOlder(currentAge);

        // Cullumative years of future college education
        int[] collegeYears = { 1, 2, 3 };
        foreach (int years in collegeYears)
        {
            currentAge = GettingOlder(currentAge, years);
        }
    }
}
