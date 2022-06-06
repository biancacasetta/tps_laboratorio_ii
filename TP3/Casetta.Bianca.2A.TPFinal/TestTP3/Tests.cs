using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestTP3
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void EstudianteSobrecargaIgualdad_CuandoElEstudianteTieneElMismoDni_DeberiaRetonarTrue()
        {
            //Arrange
            Domicilio dom = new Domicilio("Calle Falsa", 123, "Springfield", "Missouri", 1234);
            Estudiante e1 = new EstudianteParticular("Juan", "Perez", 12345678, new DateTime(1990, 08, 25), "Masculino", 1122223333, dom, ETipoEstudiante.Particular, "juanperez@gmail.com");
            Estudiante e2 = new EstudianteExterno("Maria", "Perez", 12345678, new DateTime(2000, 12, 31), "Femenino", 5491177778888, dom, ETipoEstudiante.Externo, ENivel.Cuarto_Año, "mariaperez@gmail.com");

            //Act
            bool estudianteYaIngresado = e1 == e2;

            //Assert
            Assert.IsTrue(estudianteYaIngresado);
        }

        [TestMethod]
        public void InstitutoSobrecargaIgualdad_CuandoElEstudianteEstaEnElInstituto_DeberiaRetonarTrue()
        {
            //Arrange
            Instituto instituto = new Instituto();
            Domicilio dom = new Domicilio("Calle Falsa", 123, "Springfield", "Missouri", 1234);
            Estudiante estudiante = new EstudianteParticular("Juan", "Perez", 12345678, DateTime.Now, "Masculino", 1122223333, dom, ETipoEstudiante.Particular, "juanperez@gmail.com");

            //Act
            instituto.Estudiantes.Add(estudiante);
            bool estudianteExistente = instituto == estudiante;

            //Assert
            Assert.IsTrue(estudianteExistente);
        }


    }
}
