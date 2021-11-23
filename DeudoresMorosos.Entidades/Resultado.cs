using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeudoresMorosos.Entidades
{
   public class Resultado
    {
       private string _error;
        private int _id;
        private bool _Isok;

        public Resultado(string error, int id, bool Isok)
        {
            this.Error = error;
            this.Id = id;
            this.Isok = Isok;
        }

        public string Error { get => _error; set => _error = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Isok { get => _Isok; set => _Isok = value; }
    }
}
