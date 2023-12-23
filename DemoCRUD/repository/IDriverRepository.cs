using DemoCRUD.Model;

namespace DemoCRUD.repository
{
    public interface IDriverRepository 
    {
        List<Driver> GetAllDrivers();
        Driver GetDriverById(int id);
        void AddDriver(Driver newDriver );
        void UpdateDriver(int id , Driver newDriver);
        bool DeleteDriver(int id);
    }
}
