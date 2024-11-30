
using yeniders;

try
{
    Room room1 = new Room("Kral dairesi", 200, 3);
    Room room2 = new Room("Ekonomi", 100, 1);
    Room room3 = new Room("",0,0);

    Hotel hotel = new Hotel("Iron hotel");
    hotel.AddRoom(room1);
    hotel.AddRoom(room2);
    hotel.AddRoom(room3);

    room1.ShowInfo();
    room2.ShowInfo();
    room3.ShowInfo();

    try
    {
        hotel.MakeResevation(1);
        hotel.MakeResevation(2);
        hotel.MakeResevation(3);
    }
    catch (NotAvailableException ex)
    {
        System.Console.WriteLine($"NotAvailableException: {ex.Message}");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Exception: {ex.Message}");
    }
}
catch (Exception ex)
{
    System.Console.WriteLine($"error {ex.Message}");
}


