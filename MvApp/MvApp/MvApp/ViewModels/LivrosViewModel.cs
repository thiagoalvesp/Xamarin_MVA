using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvApp.ViewModels
{
    public class LivrosViewModel : INotifyPropertyChanged
    {
        public ICommand CarregarCommand { get; set; }


        public ObservableCollection<Model.Livro> livros { get; set; }
        public ObservableCollection<Model.Livro> Livros
        {
            get { return livros; }
            set
            {
                livros = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Livros)));
            }
        }

        public LivrosViewModel() {

            Livros = new ObservableCollection<Model.Livro>();



            CarregarCommand = new Xamarin.Forms.Command(async () =>
            {
                var livrosQueRetornaramDaApi = await ApiLivros.Api.GetAsync();
                Livros = new ObservableCollection<Model.Livro>(livrosQueRetornaramDaApi);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
