int saludHeroe=10;
int saludMonstruo=10;

Random ControlAtaques=new Random();
int daño=0;
int cont=1;
bool ControlMaster=true;

while(ControlMaster){
    Console.WriteLine($"Turno {cont}");
    daño=ControlAtaques.Next(1,10);
    saludMonstruo=saludMonstruo-daño;
    Console.WriteLine("Ataca el Heroe");
    Console.WriteLine($"El Heroe ha golpeado inflinge {daño} de daño!!");
    Console.WriteLine($"Al Monstruo le queda {saludMonstruo} de salud restante!!");
    cont++;
    if(saludMonstruo>0){
       Console.WriteLine($"Turno {cont}");
       daño=ControlAtaques.Next(1,10);
       saludHeroe=saludHeroe-daño;
       Console.WriteLine("Ataca el Monstruo");
       Console.WriteLine($"El Monstruo ha golpeado inflinge {daño} de daño!!");
       Console.WriteLine($"Al Heroe le queda {saludHeroe} de salud restante!!");
       cont++;
    }        
    if(saludHeroe<=0){
       Console.WriteLine("El Heroe ha muerto Monstruo ha ganado!!");
    }
    if(saludMonstruo<=0){
       Console.WriteLine("El Monstruo ha muerto Heroe ha ganado!!");
    }
    if(saludHeroe<=0 || saludMonstruo<=0){
       ControlMaster=false;
    }   
}