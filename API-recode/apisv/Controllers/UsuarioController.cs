using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Usuarios.Data;
using Usuarios.Model;

namespace Usuarios.Controllers{
[ApiController]
  [Route("api/[controller]")]
  public class UsuarioController : ControllerBase{
    private readonly DataContext _dataContext;


    public UsuarioController(DataContext dataContext)
    {
      _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
    {
      return await _dataContext.Usuarios.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Usuario>> GetusuarioById(int id)
    {
      var usuario = await _dataContext.Usuarios.FindAsync(id);
      if (usuario == null)
      {
        return NotFound();
      }

      return Ok(usuario);
    }

  }

}