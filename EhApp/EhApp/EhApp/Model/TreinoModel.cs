using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EhApp.Model
{
    public class TreinoModel : INotifyPropertyChanged
    {

        private int idTreino;

        [PrimaryKey]
        public int IdTreino
        {
            get { return idTreino; }
            set
            {
                if (idTreino != value)
                {
                    idTreino = value;
                    NotifyPropertyChanged();
                }
            }
        }

        //*objetivo para selecionar tipos de execcs - aerobico - hipertrofia

        private String objetivoTreino;
        public String ObjetivoTreino
        {
            get { return objetivoTreino; }
            set
            {
                if (objetivoTreino != value)
                {
                    objetivoTreino = value;
                    NotifyPropertyChanged();
                }
            }
        }

        //*[]
        private String exercicioTreino;
        public String ExercicioTreino
        {
            get { return exercicioTreino; }
            set
            {
                if (exercicioTreino != value)
                {
                    exercicioTreino = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public TreinoModel()
        {
        }

        public TreinoModel(int Id, String Nome, String Objetivo, String Exercicio)
        {
            this.IdTreino = Id;
            this.ObjetivoTreino = Objetivo;
            this.ExercicioTreino = Exercicio;
        }



    }
}
