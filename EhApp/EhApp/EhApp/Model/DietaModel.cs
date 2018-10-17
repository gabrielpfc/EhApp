using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EhApp.Model
{
    public class DietaModel : INotifyPropertyChanged
    {

        private int idDieta;

        [PrimaryKey]
        public int IdDieta
        {
            get { return idDieta; }
            set
            {
                if (idDieta != value)
                {
                    idDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String nomeDieta;
        public String NomeDieta
        {
            get { return nomeDieta; }
            set
            {
                if (nomeDieta != value)
                {
                    nomeDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String dicasDieta;
        public String DicasDieta
        {
            get { return dicasDieta; }
            set
            {
                if (dicasDieta != value)
                {
                    dicasDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double carbDieta;
        public double CarbDieta
        {
            get { return carbDieta; }
            set
            {
                if (carbDieta != value)
                {
                    carbDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private double protDieta;
        public double ProtDieta
        {
            get { return protDieta; }
            set
            {
                if (protDieta != value)
                {
                    protDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double gordDieta;
        public double GordDieta
        {
            get { return gordDieta; }
            set
            {
                if (gordDieta != value)
                {
                    gordDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double kcalDieta;
        public double KcakDieta
        {
            get { return kcalDieta; }
            set
            {
                if (kcalDieta != value)
                {
                    kcalDieta = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public DietaModel()
        {
        }

        public DietaModel(int Id, String Nome, String Dicas, Double Gord, Double Carb, Double Prot, Double Kcal)
        {
            this.IdDieta = Id;
            this.NomeDieta = Nome;
            this.DicasDieta = Dicas;
            this.GordDieta = Gord;
            this.ProtDieta = Prot;
            this.CarbDieta = Carb;
            this.kcalDieta = Kcal;
        }



    }
}
