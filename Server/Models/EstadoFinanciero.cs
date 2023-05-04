
namespace Sistema_gestion_financiera.Server.Models;

public class EstadoFinanciero
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public decimal TotalActivos { get; set; }
    public decimal TotalPasivos { get; set; }
    public decimal PatrimonioNeto { get; set; }
}
