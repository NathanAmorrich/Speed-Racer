using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    int carAge = 0;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        print("The car model is "+carModel+" and has a "+engineType);
       
        CheckWeight();

        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade);

            carAge = CalculateAge(yearMade);

            print("The age of the car is "+carAge+" years old.");

        }
        else
        {
            print("The car was introduced in the 2010's");

            print("The car's maximum acceleration is " + maxAcceleration);
        }
        
        print(CheckCharacteristics());

    }

    void CheckWeight()
    {
        if(carWeight < 1500)
        {
            print("The car weights LESS than 1500kg");
        }
        else 
        {
            print("The car weights MORE than 1500kg");
        }
    }

    int CalculateAge(int age)
    {
        return 2021 - age;
    }

    string CheckCharacteristics()
    {

        if(isCarTypeSedan)
        {
          
            return "This car is a sedan";

        }
        else
        {

            if(hasFrontEngine)
            {
                
                return "This car is not a sedan but it has a front engine";

            }
            else
            {
             
                return "This car is not a sedan and has no front engine";

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
