using FilmesWebApi.Domains;
using FilmesWebApi.ViewModels;

namespace FilmesWebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório de usuários
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="login">Objeto login que contem email é senha</param>
        /// <returns>Retorna um usuário autenticado</returns>
        Usuarios Login(LoginViewModel login);
    }
}
