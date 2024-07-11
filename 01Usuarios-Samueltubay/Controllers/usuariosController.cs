using _01Usuarios_Samueltubay.Comunes;
using _01Usuarios_Samueltubay.Controllers.modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _01Usuarios_Samueltubay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        // GET: api/<usuariosController>
        [HttpGet]
        public List<Usuario> Get()
        {
            return ConexionBD.GetUsuarios();
        }

        // GET api/<usuariosController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return ConexionBD.GetUsuario(id);
        }

        // POST api/<usuariosController>
        [HttpPost]
        public void Post([FromBody] Usuario objeUsuario)
        {
            ConexionBD.PostUsuario(objeUsuario);
        }

        // PUT api/<usuariosController>/5
        [HttpPut("{Usuariomodificacion}")]
        public void Put(int Usuariomodificacion,[FromBody] Usuario objUsuario) 
        {
            ConexionBD.PutUsuario(Usuariomodificacion,objUsuario);
        }

        // DELETE api/<usuariosController>/5
        [HttpDelete("{idUsuario}/{idUsuariomodificacion}")]
        public void Delete(int idUsuario,int idUsuariomodificacion)
        {
            ConexionBD.DeleteUsuario(idUsuario, idUsuariomodificacion);
        }
    }
}
