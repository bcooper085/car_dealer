using System.Collections.Generic;

namespace CarList.Objects
{
  public class Car
  {
    private int _year;
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _drivetrain;
    private static List<string> _instances = new List<string> {};

    public Car (int year, string makeModel, int price, int miles, string drivetrain)
    {
      _year = year;
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _drivetrain = drivetrain;
    }


    public int GetYear()
    {
      return _year;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public string GetDrivetrain()
    {
      return _drivetrain;
    }


    public void SetYear(int newYear)
    {
      _year = newYear;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public void SetDrivetrain(string newDrivetrain)
    {
      _drivetrain = newDrivetrain;
    }

    // public static List<string> GetAll()
    // {
    //   return _instances;
    // }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    // public void Save()
    // {
    //   _instances.Add();
    // }
  }
}
