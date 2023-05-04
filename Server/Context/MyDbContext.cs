using Microsoft.EntityFrameworkCore;
using Sistema_gestion_financiera.Server.Models;

namespace LoanHouse.Server.Context;

public interface IMyDbContext
{
    DbSet<Empleado> Empleados { get; set; }
    DbSet<EstadoFinanciero> EstadoFinancieros { get; set; }
    DbSet<Pagos> Pagos { set; get; }
    DbSet<Presupuesto> Presupuestos { get; set; }
    DbSet<Proveedor> Proveedors { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;

    public MyDbContext(IConfiguration _config)
    {
        config = _config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("sqlServerDB"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tablas de mi base de datos
    public DbSet<Empleado> Empleados { set; get; } = null!;
    public DbSet<EstadoFinanciero> EstadoFinancieros { set; get; } = null!;
    public DbSet<Pagos> Pagos { set; get; } = null!;
    public DbSet<Presupuesto> Presupuestos { get; set; }= null!;
    public DbSet<Proveedor> Proveedors { get; set; }= null!;
    #endregion
}