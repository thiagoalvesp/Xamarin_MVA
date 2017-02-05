using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvApp.Model
{
    public class Livro : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private int id;
        public int Id {
            get { return id; }
            set
            {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
            }
        }

        public Autor Autor { get; set; }

        
    }
}
