using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste8quali.Models
{
    public class ClienteModel
    {
        [Key()]
        public int Id { get; set; }


        public string nome { get; set; }
        public string email { get; set; }
        public string empresa { get; set;}
        public string telefonePessoal { get; set;}
        public string telefonecomercial { get; set; }




    }
}
