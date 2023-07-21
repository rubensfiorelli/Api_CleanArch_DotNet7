namespace Pets.Application.Output.DTOs
{
    public struct TutorDTO
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string DocumentoNumero { get; set; }
        public string Email { get; set; }

    }
}
