using gregslist_csharp.Models;

namespace gregslist_csharp.DB;

public static class FakeDb
{
    public static List<Car> Cars { get; set; } = new List<Car>(){
    new Car("Toyota", "Tundra", 2018),
    new Car("Subaru", "Outback", 2011),
    new Car("Ford", "Ranger", 1998),
    new Car("Chevy", "Blazer", 1976)
};
}