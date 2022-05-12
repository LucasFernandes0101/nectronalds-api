using System;
using System.ComponentModel.DataAnnotations;

namespace NecTronaldsAPI.Domain.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
