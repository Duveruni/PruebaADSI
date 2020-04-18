using System;

class Program
{
    static void Main(string[] args)
    {
        int VotoUsuario = 0;
        int VotoNulo = 0;
        int VotoMaria = 0;
        int VotoDavid = 0;
        int VotoDuver = 0;
        int VotoJohan = 0;
        int VotoBlanco = 0;
        int VotoNumeroGanador = 0;
        string RespuestaUsuario = "";
        string VotoTextoganador = "";
        string VotoEmpate = "";
        
        Console.WriteLine("===Candidatos===");
        Console.WriteLine("0. Nulo");
        Console.WriteLine("1. Maria Losada");
        Console.WriteLine("2. David Ruiz");
        Console.WriteLine("3. Duver Uni");
        Console.WriteLine("4. Johan Bravo");
        Console.WriteLine("5. En Blanco");
        Console.WriteLine("6. Targeta no marcada");
       
        Console.WriteLine("Desea ingresar un nuevo voto (SI/NO)");
        RespuestaUsuario = Console.ReadLine();
        
         while (RespuestaUsuario == "SI") 
         {
            Console.Write("por favor, ingrese el numero " +
                "del candidato de su escogencia: ");
            Int32.TryParse(Console.ReadLine(), out VotoUsuario); 
            
             switch (VotoUsuario)
            {
                case 0:
                    Console.WriteLine("su voto a sido marcado como Nulo");
                    VotoNulo++;
                    break;
                case 1:
                    Console.WriteLine("usted ha votado por Maria losada");
                    VotoMaria++;

                     if  (VotoMaria > VotoNumeroGanador)
                        {
                            VotoTextoganador = "Maria";
                            VotoEmpate = "";
                            VotoNumeroGanador++;
                     }

                     else if (VotoNumeroGanador == VotoMaria)
                     {
                         VotoEmpate += ", Maria";
                     }

                    break;

                case 2:
                    Console.WriteLine("usted ha votado por David Ruiz");
                    VotoDavid++;

                    if (VotoDavid > VotoNumeroGanador)
                    {
                        VotoTextoganador = "David";
                        VotoEmpate = "";
                        VotoNumeroGanador++;
                    }

                    else if (VotoNumeroGanador == VotoDavid)
                    {
                        VotoEmpate += ", David";
                    }
                    break;

                case 3:
                    Console.WriteLine("usted ha votado por Duver Uni");
                    VotoDuver++;

                    if (VotoDuver > VotoNumeroGanador)
                    {
                        VotoTextoganador = "Duver";
                        VotoEmpate = "";
                        VotoNumeroGanador++;
                    }

                    else if (VotoNumeroGanador == VotoDuver)
                    {
                        VotoEmpate += ", Duver";
                    }
                    break;

                case 4:
                    Console.WriteLine("usted ha votado por Johan Bravo");
                    VotoJohan++;

                    if (VotoJohan > VotoNumeroGanador)
                    {
                        VotoTextoganador = "Johan";
                        VotoEmpate = "";
                        VotoNumeroGanador++;
                    }

                    else if (VotoNumeroGanador == VotoJohan)
                    {
                        VotoEmpate += ", Johan";
                    }
                    break;

                case 5:
                    Console.WriteLine("usted ha hecho un voto en Blanco");
                    VotoBlanco++;

                    if (VotoBlanco > VotoNumeroGanador)
                    {
                        VotoTextoganador = "Voto en blanco";
                        VotoEmpate = "";
                        VotoNumeroGanador++;
                    }

                    else if (VotoNumeroGanador == VotoBlanco)
                    {
                        VotoEmpate += ", Voto en blanco";
                    }
                    break;

                default:
                    Console.WriteLine("Su voto a sido marcado como Nulo");
                    VotoNulo++;
                    break;
            }
             Console.WriteLine("Desea ingresar un nuevo voto (SI/NO)");
        RespuestaUsuario = Console.ReadLine();
            
            if (RespuestaUsuario == "SI")
            {
                Console.WriteLine("0. Nulo");
                Console.WriteLine("1. Maria Losada");
                Console.WriteLine("2.David Ruiz");
                Console.WriteLine("3. Duver Uni");
                Console.WriteLine("4. Johan Bravo");
                Console.WriteLine("5. En Blanco");
                Console.WriteLine("6. Targeta no marcada");
            }
            
        }
        Console.WriteLine("===RESULTADOS===");
        Console.WriteLine("1. Maria Losada....." + VotoMaria + " Votos");
        Console.WriteLine("2. David Ruiz........" + VotoDavid + " Votos");
        Console.WriteLine("3. Duver Uni........" + VotoDuver + " Votos");
        Console.WriteLine("4. Johan Bravo......" + VotoJohan + " votos");
        Console.WriteLine("5. En Blanco........" + VotoBlanco + " votos");
        Console.WriteLine("6. Targeta no marcada" + VotoNulo + " votos");
        

        if (VotoEmpate != "")
        {
            Console.WriteLine("Se ha generado un empate entre: " + VotoTextoganador + VotoEmpate);
        }
        else
        {
        Console.WriteLine("La votacion ha arrojado como ganador a: " + VotoTextoganador);
        }
        Console.ReadLine();
    }
}
