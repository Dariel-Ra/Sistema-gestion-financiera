using System.ComponentModel.DataAnnotations;
using Sistema_gestion_financiera.Shared.Records;
using Sistema_gestion_financiera.Shared.Requests;

namespace Sistema_gestion_financiera.Server.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;
    public string CorreoElectronico { get; set; } = null!;
    public decimal SaldoPendiente { get; set; }

    public static Cliente Crear(ClienteCreateRequest request)
    {
        return new Cliente(){ 
            Nombre = request.Nombre,
            Apellido = request.Apellido,
            Dirección = request.Dirección,
            Cedula = request.Cedula,
            Telefono = request.Telefono,
        };
    }
    public ClienteRecord ToRecord()
    {
        return new ClienteRecord(Id,Nombre,Apellido,Dirección,Cedula,Telefono);
    }
}
