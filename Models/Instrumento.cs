using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace orquesta_server.Models
{
  public class Instrumento
  {
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Nombre { get; set; }
    public decimal precio { get; set; }
    public string Tipo { get; set; }
    public bool Reparacion { get; set; }
    public bool Libre { get; set; }
  }
}