namespace Pets.Application.Output.DTOs
{
    public struct VaccineDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public Guid CategoriaId { get; set; }
    }
}
