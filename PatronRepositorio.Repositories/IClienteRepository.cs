using PatronRepositorio.Entities;

namespace PatronRepositorio.Repositories
{
    public interface IClienteRepository
    {
        ICollection<Cliente> GetAll();
        Cliente? GetById(int id);
        void Add(Cliente entidad);
        void Update(int id, Cliente entidad);
        void Delete(int id);
    }
}
