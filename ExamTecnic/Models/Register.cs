using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamTecnic.Models;

public class Register
{
    [Key]
    public int IdUser { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Correo { get; set; }
    public string? Contraseña { get; set; }
}
