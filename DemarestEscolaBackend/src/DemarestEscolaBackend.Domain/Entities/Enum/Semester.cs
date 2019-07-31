using System.Runtime.Serialization;

namespace DemarestEscolaBackend.Domain.Entities.Enum
{
    public enum Semester
    {
        [EnumMember(Value = "1º Semestre")]
        Semester1 = 1,

        [EnumMember(Value = "2º Semestre")]
        Semester2 = 2,

        [EnumMember(Value = "3º Semestre")]
        Semester3 = 3,
    }
}