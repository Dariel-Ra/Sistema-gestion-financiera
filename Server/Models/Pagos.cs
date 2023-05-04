
namespace Sistema_gestion_financiera.Server.Models;

public class Pagos
{
    public int Id { get; set; }
    public DateTime FechaPago { get; set; }
    public string EntidadPago { get; set; } = null!;
    public decimal MontoPago { get; set; }
    public MetodoPago MetodoPago { get; set; }
}

public enum MetodoPago
{
    Cheque,
    Transferencia,
    Efectivo,
    Otro
}
