using Microsoft.EntityFrameworkCore;
using System;

namespace TrafficSensors.DB.DataDb
{
    public class SensorsDataDatabaseContext : DbContext
    {
        public SensorsDataDatabaseContext(DbContextOptions<SensorsDataDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Model.DetectedData> DetectedData { get; set; }
    }
}
