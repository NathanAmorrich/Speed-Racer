using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public string carMaker;
    public int carWeight = 1609;
    public int yearMade = 2009;
    public int carAge = 0;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);
   
    void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }
   
    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two-thirds.");
                break;

            case 50:
                print("Fuel level is at half amount.");
                break;

            case 10:
                print("Warning ! Fuel level is critically low.");
                break;

            default:
                print("Nothing to report.");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        print("The car model is "+carModel+" from "+carMaker+" and has a "+engineType+" engine.");
       
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

            print("The car's maximum acceleration is " +maxAcceleration+ "m/s^2");
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
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }

    }

}
