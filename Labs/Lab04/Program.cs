using System;

public class HelloWorld
{
  public static void Main(string[] args)
  {
    Console.WriteLine ("Hello Mono World");
    

    const int RESULTCOUNT = 1000;

    string [] firstNameResult = new string [RESULTCOUNT];
    string [] middleNameResult = new string [RESULTCOUNT];
    string [] lastNameResult = new string [RESULTCOUNT];
    string [] jobResult = new string [RESULTCOUNT];
    decimal [] hourlyWageResult = new decimal [RESULTCOUNT];
    decimal [] yearlySalaryResult = new decimal [RESULTCOUNT];

    string [] nameMales = new string [10] {"Liam", "John", "James", "William", "Gabriel", "Walter", "Hunter", "Alexander", "Michael", "Logan"};
    string [] nameFemales = new string [10] {"Olivia", "Emma", "Ava", "Sophia", "Isabella", "Mia", "Evelyn", "Brittany", "Hannah", "Elizabeth"};
    string [] lastNames = new  string[10] {"Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Anderson", "Thompson", "Garcia"}; //TODO: Add more names here for stability
    string [] middleNameMales = new string[10] {"Henrry", "Mateo", "Daniel", "Owen", "Samuel", "Jacob", "Asher", "Joseph", "David", "Leo"};
    string [] middleNameFemales = new string[10] {"Abigail", "Avery", "Emily", "Scarlett", "Camila", "Emily", "Hazel", "Madison", "Chloe", "Grace"};
    string [] job = new string [10] {"Architect", "Lawyer", "Musician", "Teacher", "Software Engineer", "Doctor", "Painter", "Accountant", "Chef", "Archeologist"};
    decimal [] hourlyWage = new decimal [10] {8, 9, 10, 11, 12, 13, 14, 15, 16, 17};
    decimal [] yearlySalary = new decimal [10];

    var r = new Random();
    for(int i = 0; i < RESULTCOUNT; i++) {
      //generate random names
      string randomFirstMales = nameMales[r.Next(nameMales.Length)];
      string randomMiddleNameMales = middleNameMales [r.Next(middleNameMales.Length)];
      string randomLastNames = lastNames[r.Next(lastNames.Length)];
      while(!IsNameUnique(randomFirstMales, randomMiddleNameMales, randomLastNames, firstNameResult,
                          middleNameResult, lastNameResult, i)){
         //generate new male first and middle names
          randomFirstMales = nameMales[r.Next(nameMales.Length)];
          randomMiddleNameMales = middleNameMales [r.Next(middleNameMales.Length)];
          randomLastNames = lastNames[r.Next(lastNames.Length)];
      }


      //store our names
      firstNameResult[i] = randomFirstMales;
      middleNameResult[i] = randomMiddleNameMales;
      lastNameResult[i] = randomLastNames;
      jobResult[i] = job[r.Next(job.Length)];
      hourlyWageResult[i]= hourlyWage[r.Next(hourlyWage.Length)];
      //TODO:add further assignments here to store the rest of the names

      i++;
      string randomFirstFemales = nameFemales[r.Next(nameFemales.Length)];
      string randomMiddleNameFemales = middleNameFemales[r.Next(middleNameFemales.Length)];
      randomLastNames = lastNames[r.Next(lastNames.Length)];

      while(!IsNameUnique(randomFirstFemales,randomMiddleNameFemales,randomLastNames,firstNameResult,
                          middleNameResult, lastNameResult, i)){
         //generate new female first and middle names
          randomFirstFemales = nameFemales[r.Next(nameFemales.Length)];
          randomMiddleNameFemales = middleNameFemales[r.Next(middleNameFemales.Length)];
          randomLastNames = lastNames[r.Next(lastNames.Length)];
      }
      //generate the jobs
      firstNameResult[i] = randomFirstFemales;
      middleNameResult[i] = randomMiddleNameFemales;
      lastNameResult[i] = randomLastNames;
      jobResult[i] = job[r.Next(job.Length)];
      hourlyWageResult[i]= hourlyWage[r.Next(hourlyWage.Length)];

      //Either print the results now, or add another loop later that iterates through them all again
    }
    
    for(int i = 0; i < 1000; i++) {
       Console.Write (firstNameResult[i] + " " + middleNameResult[i] + " " + lastNameResult[i] + " ");
       Console.Write (jobResult[i] );
       Console.Write (" " );
       Console.Write (hourlyWageResult[i] );
       Console.Write (" " );
       Console.WriteLine (hourlyWageResult[i]*40*50 );
    }

  }

    /* subroutine IsNameUnique - this needs to be a separate method */
    private static bool IsNameUnique(string first, string mid, string last, 
                                      string[] firstsUsed, string[] midsUsed, string[] lastsUsed, int size){
      for(int i = 0; i < size; i++){
        if(first==firstsUsed[i] && mid==midsUsed[i] && last==lastsUsed[i]){
          return false; //if we found a match, it's been used; return false, this isn't unique
        }    
      }
      return true; //only return true if we got through the list and found no matches
    }
}   