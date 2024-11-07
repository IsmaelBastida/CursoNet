namespace Curso{

    class Foo{
        public Foo(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; init; }
        public string Name { get; init; }

        // override object.Equals
    }


    public abstract class Ave {
        public int Peso { get; set; }
    }

    public abstract class AveVoladora: Ave {

        public AveVoladora(int peso, int velocidad){
            base.Peso = peso;
            this.Velocidad = velocidad;
        }
        public int Velocidad { get; set; }
    }

    public abstract class AveNoVoladora:Ave {
      public AveNoVoladora(int peso)
      {
        base.Peso = peso;
      }
    }

    public class Pinguino: AveVoladora {
        public Pinguino(int peso){
            base.Peso = peso;
        }
    }

    public class Aguila: AveVoladora {
        public Aguila(int peso, int velocidad){
            base.Peso = peso;
            base.Velocidad = velocidad;
        }
    }
}