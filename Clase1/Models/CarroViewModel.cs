using Clase1.Validators;

using System.ComponentModel.DataAnnotations;
 
namespace Clase1.Models

{

    public class CarroViewModel

    {

        [Required(ErrorMessage = "La marca del carro es  requerida")]

        public string? marca { get; set; }

        [CarroModeloValidator]

        public string? modelo { get; set; }

    }

}
