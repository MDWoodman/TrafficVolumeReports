using Microsoft.EntityFrameworkCore;
using System;
using TrafficSensors.DB.SensorsDb.Model;

namespace TrafficSensors.DB.SensorsDb
{
    public class SensorDatabaseContext : DbContext
    {
        public SensorDatabaseContext(DbContextOptions<SensorDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Model.Sensor> Sensors { get; set; }
    }
}
