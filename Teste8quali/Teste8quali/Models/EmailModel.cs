using System.ComponentModel.DataAnnotations;

namespace Teste8quali.Models
{
    public class EmailModel
    {
        [Key()]
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
