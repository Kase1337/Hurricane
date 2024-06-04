using System;

class Program {
  public static void Main (string[] args) {
    //Category information taken from "Saffir-Simpson Hurricane Scale" link: https://www.weather.gov/mfl/saffirsimpson#:~:text=The%20Saffir%2DSimpson%20Hurricane%20Wind,loss%20of%20life%20and%20damage. 
    
    //speed and category and input variales
    double windspeed;
    string category;
    string input;

   
    
    // Prompt the user to enter the wind speed
        Console.Write("Please enter the wind speed in miles per hour: ");

    //Read the windspeed entered from by user and convert the input to an integer
      //  windspeed = Convert.ToDouble(Console.ReadLine()); 

    //read the entered 
  input = Console.ReadLine();
    
    // Remove mph from the input string and then parse the information to double to determinate the hurricane category based on the wind category entered by the user

    
      if (double.TryParse(input.Replace(" mph", ""), out windspeed))
      {
        if (windspeed >= 157)
        {
            category = "Category Five Hurricane"; // Category 5
        }
        else if (windspeed >= 130)
        {
            category = "Category Four Hurricane"; // Category 4
        }
        else if (windspeed >= 111)
        {
            category = "Category Three Hurricane"; // Category 3
        }
        else if (windspeed >= 96)
        {
            category = "Category Two Hurricane"; // Category 2
        }
        else if (windspeed >= 74)
        {
            category = "Category One Hurricane"; // Category 1
        }
        else
        {
            category = "Not a Hurricane"; // Not a hurricane, more likely a tropical storm.
        }
    // If none of the above returns true then the windspeed is not a hurricane.
    // Print the windspeed and category to the console
         Console.WriteLine(category);
    }

    else // If the input is not a valid number, print an error message.
    {
        Console.WriteLine("Invalid input. Please enter the wind speed in the format 'value mph'.");
    }


    }
  }
  
