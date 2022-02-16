using System.ComponentModel.DataAnnotations;

namespace Teste8quali.Models
{
    public class EmailModel
    {
        
        public int Id { get; set; }
        public string Email { get; set; }
        public int ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}
