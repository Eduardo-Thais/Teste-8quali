using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste8quali.Models
{
    public class ClienteModel
    {
        
        public int Id { get; set; }


        public string Nome { get; set; }
        public ICollection<EmailModel> Emails { get; set; }
        public string Empresa { get; set;}
        public string TelefonePessoal { get; set;}
        public string Telefonecomercial { get; set; }




    }
}
