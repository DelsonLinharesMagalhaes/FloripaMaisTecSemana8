 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BasicApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(int Id, string Nome)
        {
            Id = Id;
            Nome = Nome;
        }
    }
} 