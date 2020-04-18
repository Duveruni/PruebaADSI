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
            //por favor, ingrese el numero de su candidato de su escogencia:
            //===Candidatos===
            ////0. Nulo
            //1. Maria Losada
            //2.David Ruiz
            //3. Duver Uni
            //4. Johan Bravo
            //5. En Blanco
            //6. Targeta no marcada
            Console.WriteLine("por favor, ingrese el numero " + 
                "del candidato de su escogencia: ");
            Int32.TryParse(Console.ReadLine(), out VotoUsuario);

            switch (VotoUsuario)
                case 0:
                    Console.WriteLine("su voto a sido marcado como Nulo");
                    VotoNulo++:
                    break;
                case 1:
                    Console.WriteLine("usted ha votado por Maria losada");
                    VotoMaria++:
                    break;

                    case 2:
                    Console.WriteLine("usted ha votado por David Ruiz");
                    VotoDavid++:
                    break;
                    case 3:
                    Console.WriteLine("usted ha votado por Duver Uni");
                    VotoDuver++:
                    break;
                    case 4:
                    Console.WriteLine("usted ha votado por Johan Bravo");
                    VotoJohan++:
                    break;
                    case 5:
                    Console.WriteLine("usted ha hecho un voto en Blanco");
                    VotoBlanco++:
                    break;
                //Continua el ejercicio...
                default:
                    Console.WriteLine("Su voto a sido marcado como Nulo");
                    VotoNulo++;
                    break;
        }
        //===RESULTADOS===
        //1. Maria Losada.....3 Votos
        //2.David Ruiz........2 Votos
        //3. Duver Uni........5 Votos
        //4. Johan Bravo
        //5. En Blanco
        //6. Targeta no marcada
    }

