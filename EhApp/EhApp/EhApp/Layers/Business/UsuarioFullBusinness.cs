using System;
using EhApp.Model;
using System.Linq;

namespace EhApp.Layers.Business
{
    public class UsuarioFullBusiness
    {

        public Model.UsuarioFullModel GetUsuarioFullLogged()
        {
            var UsuarioFull = new Data.UsuarioFullData().Get();

            if (UsuarioFull != null)
            {
                UsuarioFull.CartilhaUsuarioFull =
                              Global.Perfis.SingleOrDefault(
                                  p => p.IdPerfil == UsuarioFull.IdPerfil);
            }

            return UsuarioFull;
        }


        public Model.InvestidorModel Get(int _id)
        {
            var UsuarioFull = new Service.UsuarioFullService().Get(_id);

            if (UsuarioFull != null)
            {
                UsuarioFull.PerfilInvestidor =
                              Global.Perfis.SingleOrDefault(
                                  p => p.IdPerfil == UsuarioFull.PerfilUsuarioFull.IdPerfil);
            }

            // Atualiza os dados Globais com o investidor.
            Global.Investidor = UsuarioFull;

            return UsuarioFull;
        }


        public void SaveInvestidorLogged(InvestidorModel _investidor)
        {
            new Data.InvestidorData().Insert(_investidor);
        }

        public void Save(InvestidorModel _investidor)
        {
            new Service.InvestidorService().Save(_investidor);
            new Data.InvestidorData().Update(_investidor);
        }



    }
}
