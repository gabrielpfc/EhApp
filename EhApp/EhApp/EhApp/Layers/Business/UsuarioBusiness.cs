using System;
using EhApp.Layers.Service;
using EhApp.Model;

namespace EhApp.Layers.Business
{
    public class UsuarioBusiness
    {

        public Model.InvestidorModel Login(string email, string senha)
        {

            // Efetuar o login
            var _usuario =
                    new UsuarioService().Login(new UsuarioModel(email.ToLower(), senha.ToLower()));

            // Consultar os dados do usuario (Caso login sucesso).
            var _investidor = new InvestidorModel();

            if (_usuario.IdUsuario != 0)
            {
                _investidor = new UsuarioFullService().Get(_usuario.IdUsuario);

                if (_investidor != null)
                {
                    // Grava os dados do investidor no dispositivo
                    new UsuarioFullBusiness().SaveFullUsuarioLogged(_usuariofull);
                }

            }

            if (_investidor == null)
            {
                throw new Exception("Não foi possível efetuar o logon");
            }


            return _investidor;


        }

    }
}
