using SQLite.Net.Attributes;
using System.ComponentModel;

namespace TrabalhoFinalGitHub.Models
{
    public class UsuarioModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));

            }
        }

        private string nome;

        [NotNull]
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
            }
        }


        public UsuarioModel(string nome)
        {
            this.Id = 0;
            this.Nome = nome;
        }

        public UsuarioModel()
        {
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}