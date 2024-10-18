using UnityEngine;

public class MethodOverload : MonoBehaviour
{
    // The first GettingOlder method increasing age by 1
    public int GettingOlder(int currentAge)
    {
        currentAge += 1;

        Debug.Log($"You are aging rapidly and you are now {currentAge} years old. Yikes...");

        return currentAge;
    }

    // The second GettingOlder method increasing age by the 
    // length of my ongoing college education
    public int GettingOlder(int currentAge, int letsGoToCollege)
    {
        currentAge += letsGoToCollege;

        // Yes this string is a bit long.
        Debug.Log($"You are aging rapidly and now you chose to go to college for {letsGoToCollege} years?! You are now {currentAge} years old. And without a pension plan.");

        return currentAge;
    }

    void Start()
    {
        // Declaring my age
        int myAge = 33;
        myAge = GettingOlder(myAge);

        // Now you might argue that random isn't a predefined value
        // But to that I argue that the value is predefined by being coded as a random value
        // Ergo, it is predefined value
        // This was fun, thank you for coming to my TED talk
        int randomYears = Random.Range(1, 8);
        myAge = GettingOlder(myAge, randomYears);
    }
    // PS. And I am sorry for violating all conventions of effective method and variable naming
}
