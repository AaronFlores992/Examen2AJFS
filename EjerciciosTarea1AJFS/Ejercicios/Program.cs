// Aaron Jair Flores Salazar 4B IS

Automovil auto1 = new Automovil(12345, "Toyota", "Supra", 12000, 600000);
Automovil auto2 = new Automovil(12345, "Honda", "CRV", 14000, 500000);
Automovil auto3 = new Automovil(12345, "Honda", "Civic", 16000, 600000);

AutomovilDeLujo automovilDeLujo = new AutomovilDeLujo(123, "Nissan", "GTR", 0, 100000000);
automovilDeLujo.agregarAireAcondicionado();
automovilDeLujo.agregarVentanaElectrica();

Concesionaria concesionaria = new Concesionaria(4);

concesionaria.agregarAuto(auto1);
concesionaria.agregarAuto(auto2);
concesionaria.agregarAuto(auto3);
concesionaria.agregarAuto(automovilDeLujo);

Automovil auto4 = new Automovil(12345, "Hon", "Accord", 16000, 500000);
concesionaria.agregarAuto(auto4);
concesionaria.mostrarAuto(auto4);
// no lo debe mostrar ya que el limite solo permite 4 porque es el que se está indicando al crear el objeto, asi que no lo agregó y no se encuentra en el array

concesionaria.mostrarAuto(auto3);

concesionaria.eliminarAuto(auto3);
concesionaria.mostrarAuto(auto3); // ya no lo debería mostrar porque ya se eliminó

concesionaria.mostrarAutos();

concesionaria.vaciarConcesionaria();

concesionaria.numeroActualAutos();// nada mas para verificar que si se borren o sumen los autos al array.





public class Automovil {
    private int _id;
    private string _marca;
    private string _modelo;
    private int _km;
    private float _precio;

    public Automovil(int id, string marca, string modelo, int km, float precio) { 
        this._id = id;
        this._marca = marca;
        this._modelo = modelo;
        this._km = km;
        this._precio = precio;  
    }
    public int id { set; get; }
    public string marca { set; get; }
    public string modelo { set; get; }
    public int km { set; get; }
    public float precio { set; get; }

    public override string ToString()
    {
        return $"ID: {this._id}, Marca: {this._marca}, Modelo: {this._modelo}, KM: {this._km}, Precio: {this._precio} \n";
    }


}


public class AutomovilDeLujo : Automovil
{
    private Boolean _aireAcondicionado;
    private Boolean _VentanaElectrica;
    private Boolean _AsientosPremium;
    private Boolean _PantallaTouch;

    public AutomovilDeLujo(int id, string marca, string modelo, int km, float precio) : base(id, marca, modelo, km, precio)
    {
        this._aireAcondicionado = false;
        this._VentanaElectrica = false;
        this._PantallaTouch = false;
        this._PantallaTouch = false;
    }

    public void agregarAireAcondicionado() 
    {
        this._aireAcondicionado = true;
        this.precio += 10000;
    }

    public void agregarVentanaElectrica() 
    {
        this._VentanaElectrica = true;
        this.precio += 20000; 
    }

    public void agregarPantallaTouch()
    {
        this._PantallaTouch = true;
        this.precio += 15000;
    }

    public void agregarAsientosPremium() 
    { 
        this._AsientosPremium = true;
        this.precio += 20000;
    }

    public override string ToString()
    {

        string extras = "";
        if (_aireAcondicionado)
        {
            extras += "Aire Acondicionado, ";

        }
        if (_VentanaElectrica)
        {
            extras += "Ventan Electrica, ";
        }
        if (_AsientosPremium)
        {
            extras += "Asientos Premium, ";
        }
        if (_PantallaTouch)
        {
            extras += "Pantalla Touch";
        }
        extras += "\n";

        return base.ToString() + extras;
    }

}

public class Concesionaria {

    private Automovil[] automoviles;
    private int limiteAutoviles;
    private int numActualAutos;

    public Concesionaria(int limiteAutomoviles) {
        this.automoviles = new Automovil[limiteAutomoviles];
        this.limiteAutoviles = limiteAutomoviles;
        this.numActualAutos = 0;
    }

    public void agregarAuto(Automovil auto) {
        if (auto != null) {
            if (numActualAutos < limiteAutoviles) {
                automoviles[numActualAutos] = auto;
                numActualAutos++;
            }
        }  
    }

    public void mostrarAuto(Automovil auto) {
        if (auto != null) {
            for (int contador = 0; contador < automoviles.Length; contador++) {
                if (automoviles[contador].Equals(auto)) {
                    Console.WriteLine(auto.ToString());
                }
            }
        }
    }

    public void eliminarAuto(Automovil auto) {
        if (auto != null) { 
            if(automoviles.Length != 0){
                int indiceRemover = obtenerIndice(auto);
                if (indiceRemover != 1) {
                    automoviles = automoviles.Where((source, index ) => index != indiceRemover).ToArray();
                    numActualAutos--;
                }
            }
        }
    }

    private int obtenerIndice(Automovil auto) {
        int indice = -1;
        for(int contador = 0; contador < automoviles.Length; contador++) {
            if (automoviles[contador].Equals(auto)){
                indice = contador;
            }
        }
        return indice;  
    }

    public void mostrarAutos() {
        Console.WriteLine("Autos de la Concesionaria: \n");
        foreach(Automovil auto in automoviles) {
            Console.WriteLine(auto.ToString() + "\n");
        }
    }

    public void vaciarConcesionaria() {
        Console.WriteLine("Vaciando Concesionaria... \n");
        foreach (Automovil auto in automoviles){
            eliminarAuto(auto);
        }
        Console.WriteLine("Concesionaria vacia \n");

    }

    public void numeroActualAutos() {
        Console.WriteLine(numActualAutos);
    }

}

