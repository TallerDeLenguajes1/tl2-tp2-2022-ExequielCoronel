
namespace TPN2
{
    enum Curso
    {
        Atletismo,Voley,Futbol
    }
    class Alumno
    {
        private int ID;
        private string Nombre;
        private string Apellido;
        private Int64 DNI;
        private Curso curso;
        public int ID1 { get => ID; set => ID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public Int64 DNI1 { get => DNI; set => DNI = value; }
        internal Curso Curso { get => curso; set => curso = value; }
    
        public Alumno(int ID, string Nombre, string Apellido, Int64 DNI, Curso curso)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
            this.Curso = curso;
        }
    } 
}
