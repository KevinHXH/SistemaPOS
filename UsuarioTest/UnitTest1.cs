using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidad;
using Datos;
using LogicaNegocio;

namespace UsuarioTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearUsuarioTest()
        {
            //Usuario creado
            Usuario u = new Usuario();
            u.idUsuario = 207730811;
            u.nombreUsuario = "kevin";
            u.password = "kevin1897jcm";
            TipoUsuario tipo = new TipoUsuario();
            tipo.idTipoUsuario = 1;
            tipo.nombreTipoUsuario = "Administrador";
            u.tipoUsuario = tipo;

            //Usuario obtenido
            Usuario usuarioRegistrado = UsuarioLN.registrarUsuario("kevin", "kevin1897jcm",1);

            Assert.AreEqual(u, usuarioRegistrado);
        }

        [TestMethod]
        public void LoginUsuarioTest()
        {
            //Usuario esperado
            Usuario u = new Usuario();
            u.idUsuario = 207730811;
            u.nombreUsuario = "kevin";
            u.password = "kevin1897jcm";
            TipoUsuario tipo = new TipoUsuario();
            tipo.idTipoUsuario = 1;
            tipo.nombreTipoUsuario = "Administrador";
            u.tipoUsuario = tipo;
            
            //Usuario obtenido
            Usuario usuarioSesion = UsuarioLN.iniciarSesion("kevin", "kevin1897jcm");

            Assert.AreEqual(u, usuarioSesion);
        }





    }
}
