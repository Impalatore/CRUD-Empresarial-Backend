namespace CRUD_Empresarial_Backend.Models;

public class Empleado
{
    public int id { get; set; }
    public string nombres { get; set; }
    public string apellidoPaterno { get; set; }
    public string apellidoMaterno { get; set; }
    public int departamentoID { get; set; }
    public string email { get; set; }
    public int telefono { get; set; }
    public string direccion { get; set; }
    public string fechaIngreso { get; set; }
    public byte archivoFoto { get; set; }
}