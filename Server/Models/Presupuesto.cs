
namespace Sistema_gestion_financiera.Server.Models;

public class Presupuesto
{
    public int Id { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public decimal IngresosPrevistos { get; set; }
    public decimal GastosPrevistos { get; set; }
}