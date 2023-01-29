﻿using API.BOBERTO.AUTHENTICATION.APPLICATION.Services.CurrentUser.Models;

namespace API.BOBERTO.AUTHENTICATION.APPLICATION.Services.CurrentUser
{
    public interface ICurrentUserService
    {
        /// <summary>
        /// Obter o usuário logado usando o claim principal
        /// </summary>
        public Profile ObterUsuarioLogado();

        /// <summary>
        /// Obtém se usuário logado tem autenticação dupla ativa
        /// </summary>
        public AutenticacaoDupla ObterAutenticacaoDuplaAtiva();

        /// <summary>
        /// Ativa autenticação dupla do usuário
        /// </summary>
        public void AtivarAutenticacaoDupla(AutenticacaoDupla autenticacoes);

    }
}
