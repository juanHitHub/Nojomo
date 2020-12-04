namespace Nojomo.Core.Entities
{
    public class UserWithToken:Usuario
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public UserWithToken(Usuario user)
        {
            this.Id = user.Id;
            this.Email = user.Email;
            this.Alias = user.Alias;
            this.Nombre = user.Nombre;
            this.Tipo = user.Tipo;
        }

    }
}
