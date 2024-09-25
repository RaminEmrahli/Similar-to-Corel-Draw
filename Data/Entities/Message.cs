using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int GrupId { get; set; }
        public Grup Grup { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
