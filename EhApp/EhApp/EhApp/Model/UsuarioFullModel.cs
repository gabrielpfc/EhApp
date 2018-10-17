using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EhApp.Model
{
    public class UsuarioFullModel : INotifyPropertyChanged
    {


        private int idUsuarioFull;

        [PrimaryKey]
        public int IdUsuarioFull
        {
            get { return idUsuarioFull; }
            set
            {
                if (idUsuarioFull != value)
                {
                    idUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private TreinoModel treinoUsuarioFull;
        [OneToOne(foreignKey: "IdTreino")]
        public TreinoModel TreinoUsuarioFull
        {
            get { return treinoUsuarioFull; }
            set
            {
                if (treinoUsuarioFull != value)
                {
                    treinoUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private DietaModel dietaUsuarioFull;
        [OneToOne(foreignKey: "IdDieta")]
        public DietaModel DietaUsuarioFull
        {
            get { return dietaUsuarioFull; }
            set
            {
                if (dietaUsuarioFull != value)
                {
                    dietaUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String nomeUsuarioFull;
        public String NomeUsuarioFull
        {
            get { return nomeUsuarioFull; }
            set
            {
                if (nomeUsuarioFull != value)
                {
                    nomeUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String emailUsuarioFull;
        public String EmailUsuarioFull
        {
            get { return emailUsuarioFull; }
            set
            {
                if (emailUsuarioFull != value)
                {
                    emailUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String objetivoUsuarioFull;
        public String ObjetivoUsuarioFull
        {
            get { return objetivoUsuarioFull; }
            set
            {
                if (objetivoUsuarioFull != value)
                {
                    objetivoUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string atividadeUsuarioFull;
        public string AtividadeUsuarioFull
        {
            get { return atividadeUsuarioFull; }
            set
            {
                if (atividadeUsuarioFull != value)
                {
                    atividadeUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double pesoUsuarioFull;
        public double PesoUsuarioFull
        {
            get { return pesoUsuarioFull; }
            set
            {
                if (pesoUsuarioFull != value)
                {
                    pesoUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private double alturaUsuarioFull;
        public double AlturaUsuarioFull
        {
            get { return alturaUsuarioFull; }
            set
            {
                if (alturaUsuarioFull != value)
                {
                    alturaUsuarioFull = value;
                    NotifyPropertyChanged();
                }
            }
        }


    



        public UsuarioFullModel()
        {
        }

        public UsuarioFullModel(int _id)
        {
            this.IdUsuarioFull = _id;
        }

        public UsuarioFullModel(int Id, String Nome, String Email, Double Peso, Double Altura, String Objetivo, String Atividade, TreinoModel Treino, DietaModel Dieta)
        {
            this.IdUsuarioFull = Id;
            this.NomeUsuarioFull = Nome;
            this.EmailUsuarioFull = Email;
            this.PesoUsuarioFull = Peso;
            this.AlturaUsuarioFull = Altura;
            this.ObjetivoUsuarioFull = Objetivo;
            this.AtividadeUsuarioFull = Atividade;
            this.TreinoUsuarioFull = Treino;
            this.DietaUsuarioFull = Dieta;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
