namespace ApiCliente.Services.Models.responses
{
    public class ClientesReponse
    {
        public int? Status { get; set; }
        public string? Mensagem { get; set; }
        public ClientesViewModel? Cliente { get; set; }

    }
}
