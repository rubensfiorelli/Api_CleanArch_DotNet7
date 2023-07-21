using Pets.Domain.Enums;

namespace Pets.Domain.ValueObjects
{
    public struct Documento
    {
        public Documento(string documentoNumero, EDocumentoTipo documentoTipo)
        {
            DocumentoNumero = documentoNumero;
            DocumentoTipo = documentoTipo;
        }

        public string DocumentoNumero { get; private set; }
        public EDocumentoTipo DocumentoTipo { get; private set; }

    }
}
