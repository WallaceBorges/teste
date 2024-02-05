using System.ComponentModel.DataAnnotations;

namespace ApiCliente.Services.Models.Requests
{
    public class ClientesUpdateRequest
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [RegularExpression(pattern: "^[A-Z\\s]{6,15}$", ErrorMessage = "Nome informado é inválido")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string? Telefone { get; set; }



    }
}
