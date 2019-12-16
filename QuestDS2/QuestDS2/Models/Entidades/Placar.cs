using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestDS2.Models
{
    public class Placar
    {
        public int PlacarId { get; set; }

        public virtual Jogador Jogador { get; set; }
        [Required(ErrorMessage = "O campo Jogador é obrigatório.", AllowEmptyStrings = false)]
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "O campo Pontos é obrigatório.", AllowEmptyStrings = false)]
        [Range(0, 999999)]
        public int Pontos { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O campo Data é obrigatório.", AllowEmptyStrings = false)]
        public DateTime Data { get; set; }
    }
}
