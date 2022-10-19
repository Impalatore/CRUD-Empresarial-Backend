using CRUD_Empresarial_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Empresarial_Backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
}