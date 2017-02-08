using Nancy;
using CarList.Objects;
using System.Collections.Generic;

namespace CarList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      // Get["/view_vehicles"] = _ => {
      //   // List<string> allCars = Car.GetAll();
      //   return View["view_vehicles.cshtml"];
      // };
      Get["/add_vehicle"] = _ => {
        Car addCar = new Car(Request.Query["year"], Request.Query["makeModel"], Request.Query["price"], Request.Query["miles"], Request.Query["drivetrain"]);
        return View["vehicle_added.cshtml", addCar];
      };
      // Post["/clear_vehicles"] = _ => {
      //   Car.ClearAll();
      //   return View["index.cshtml"];
      // };
    }
  }
}
