using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace EhApp.Model
{
public class CartilhaModel : INotifyPropertyChanged
    {

        private int idCartilha;

        [PrimaryKey]
        public int IdCartilha
        {
            get { return idCartilha; }
            set
            {
                if (idCartilha != value)
                {
                    idCartilha = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [ForeignKey(typeof(TreinoModel))]
        public int IdTreino
        {
            get; set;
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public CartilhaModel()
        {
        }




    }
}
