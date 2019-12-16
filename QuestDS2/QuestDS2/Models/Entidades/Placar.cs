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
        public int JogadorId { get; set; }

        [Display(Description = "Quantidade de pontos obtida:")]
        public int Pontos { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Description = "Data da pontuação:")]
        public DateTime Data { get; set; }
    }
}
