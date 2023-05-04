
namespace Sistema_gestion_financiera.Server.Models;

public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }  = null!;
    public string Direccion { get; set; }  = null!;
    public string Telefono { get; set; }  = null!;
    public string CorreoElectronico { get; set; }  = null!;
    public decimal SalarioBase { get; set; }
    public decimal DeduccionesNomina { get; set; }
}
