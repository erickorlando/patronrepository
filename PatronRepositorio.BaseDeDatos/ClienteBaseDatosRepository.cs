using PatronRepositorio.Entities;
using PatronRepositorio.Repositories;

namespace PatronRepositorio.BaseDeDatos;

public class ClienteBaseDatosRepository : IClienteRepository
{
    private readonly GalaxyDbContext _context;

    public ClienteBaseDatosRepository(GalaxyDbContext context)
    {
        _context = context;
    }

    public ICollection<Cliente> GetAll()
    {
        return _context.Clientes.ToList();
    }

    public Cliente? GetById(int id)
    {
        return _context.Clientes.Find(id);
    }

    public void Add(Cliente entidad)
    {
        _context.Clientes.Add(entidad);
        _context.SaveChanges();
    }

    public void Update(int id, Cliente entidad)
    {
        var registro = GetById(id);
        if (registro is null) return;
        registro.Nombres = entidad.Nombres; 
        registro.Apellidos = entidad.Apellidos;
        registro.CorreoElectronico = entidad.CorreoElectronico;

        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var registro = GetById(id);
        if (registro is not null)
        {
            _context.Clientes.Remove(registro);
            _context.SaveChanges();
        }
    }
}