using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? Enter 1 to add or 2 to view.");

      string response = Console.ReadLine();
      if (response == "1")
      {
        Console.WriteLine("Please enter the description for the new item.");
        response = Console.ReadLine();
        Item usersList = new Item(response);//this is where we will do the business logic and add the user input to the list
        Console.WriteLine(response + " has been added to your list.");
        Main(); 
      }
      else if (response == "2")// user wants
      {
        List<Item> result = Item.GetAll();
        for(int i=0; i<result.Count; i++)
        {
          Console.WriteLine((i+1) + ". " + result[i].Description);
        }
       
        Main(); 
      }
    
    }
  }
}