using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestDS2.Models
{
    public class Jogador
    {
        
        public int JogadorId { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Idade é obrigatório.", AllowEmptyStrings = false)]
        public int Idade { get; set; }
        [Required(ErrorMessage = "O campo Nacionalidade é obrigatório.", AllowEmptyStrings = false)]
        public string Nacionalidade { get; set; }
    }
}
