using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace orquesta_server.Models
{
  public class Musico
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string Tipo { get; set; }
    public int? InstrumentoId { get; set; }
    public decimal Sueldo { get; set; }
  }
}