using FilmesWebApi.Contexts;
using FilmesWebApi.Domains;
using FilmesWebApi.Interfaces;
using FilmesWebApi.ViewModels;
using System.Linq;

namespace FilmesWebApi.Repositories
{
    /// <summary>
    /// Repositório que implementa os métodos de usuários
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Instancia um novo contexto para utilizar os métodos do EF Core
        /// </summary>
        FilmesContext ctx = new FilmesContext();

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="usuario">Objeto usuario que contem o email é a senha</param>
        /// <returns>Retorna um usuário autenticado</returns>
        public Usuarios Login(LoginViewModel usuario)
        {
            // Busca um usuário através do e-mail e senha informados
            Usuarios usuarioAutenticado = ctx.Usuarios
                .FirstOrDefault(u => u.Email == usuario.Email && u.Senha == usuario.Senha);

            // Caso seja encontrado, retorna todos os dados deste usuário
            if (usuarioAutenticado != null)
            {
                return usuarioAutenticado;
            }

            // Caso não, retorna nulo
            return null;
        }
    }
}
