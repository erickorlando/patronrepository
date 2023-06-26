using PatronRepositorio.Entities;

namespace PatronRepositorio.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly List<Cliente> _list;

        public ClienteRepository()
        {
            _list = new List<Cliente>
            {
                new Cliente
                {
                    Id = 1,
                    Nombres = "Juan",
                    Apellidos = "Perez",
                    CorreoElectronico = "juan@hotmail.com"
                },
                new Cliente
                {
                    Id = 2,
                    Nombres = "Jose",
                    Apellidos = "Guzman",
                    CorreoElectronico = "jose@hotmail.com"
                },
            };
        }

        public ICollection<Cliente> GetAll()
        {
            return _list;
        }

        public Cliente? GetById(int id)
        {
            return _list.Find(p => p.Id == id);
        }

        public void Add(Cliente entidad)
        {
            entidad.Id = _list.Count + 1;
            _list.Add(entidad);
        }

        public void Update(int id, Cliente entidad)
        {
            var registro = GetById(id);
            if (registro is null) return;
            registro.Nombres = entidad.Nombres;
            registro.Apellidos = entidad.Apellidos;
            registro.CorreoElectronico = entidad.CorreoElectronico;
        }

        public void Delete(int id)
        {
            var registro = GetById(id);
            if (registro is not null)
            {
                _list.Remove(registro);
            }
        }
    }
}