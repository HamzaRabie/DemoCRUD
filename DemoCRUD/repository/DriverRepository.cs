using DemoCRUD.Data;
using DemoCRUD.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DemoCRUD.repository
{
    public class DriverRepository : IDriverRepository
    {
        AppDbContext context;

        public DriverRepository(AppDbContext context)
        {
            this.context = context;
        }

        public List<Driver> GetAllDrivers()
        {
            List<Driver> drivers;
            drivers = context.Drivers.ToList();
            return drivers;
        }

        public Driver GetDriverById(int id)
        {
            Driver driver = context.Drivers.FirstOrDefault(x => x.Id == id);
            return driver;
        }

        public void AddDriver(Driver driver)
        {
            context.Drivers.Add(driver);
            context.SaveChanges();

        }

        public bool DeleteDriver(int id)
        {
            
            Driver oldDriver = GetDriverById(id);
            if (oldDriver == null) 
                return false;
            context.Drivers.Remove(oldDriver);
            context.SaveChanges();
            return true;
        }

        public void UpdateDriver(int id ,  Driver newDriver)
        {
            Driver oldDriver = GetDriverById(id) ;
            oldDriver.Name = newDriver.Name;
            oldDriver.Phone = newDriver.Phone;
            oldDriver.DriverNumber  = newDriver.DriverNumber;

            context.SaveChanges();
        }

        
    }
}
