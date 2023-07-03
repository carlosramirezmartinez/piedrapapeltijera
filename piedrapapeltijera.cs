using System;

/****************************
*  Piedra    Papel   Tijera *
*   1        2        3     *
*   👊   -   ✋   -   ✌️    *
****************************/

namespace piedrapapeltijera
{
	class Program
	{
		static void Main(string[] args)
		{
            UniEnable();
            int jugador = Convert.ToInt32(Console.ReadLine()); 
            int computer = JugarCpu();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Tu eleccion es: " + NumToStr(jugador));
            Console.WriteLine("La CPU eligió: " + NumToStr(computer));
            string resu = CompararResultado(jugador, computer);
            Console.WriteLine($"El resultado es: {resu}");
		}

        //imprimir numero a emoji
        public static string NumToStr(int Num){
            string resu = "";
            switch (Num){
                case 1:
                    resu = "Piedra 👊";
                    break;
                case 2:
                    resu = "Papel ✋";
                    break;
                case 3:
                    resu = "Tijeras ✌️";
                    break;
            }
            return resu;
        }

        //habiltar unicode en el programa
        public static void UniEnable() {
          Console.OutputEncoding = System.Text.Encoding.UTF8;
          Console.Write("\xfeff"); 
        }

        //jugadacpu
        public static int JugarCpu(){
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }

        public static string CompararResultado(int jugador, int computer){
        
            string  ganar ="Ganaste 😊",
                    perder ="Perdiste 😔", 
                    empatar ="Empate 🙌", 
                    err ="No eligió nada," +
                    "por favor pulse 1: Piedra, 2: Papel, 3. Tijera";
            string msg = "";
            
            // jugador elige piedra
            if (jugador == 1)
            {
                if (computer == 1)
                {msg = empatar;}
                else if (computer == 2)
                {msg = perder;}
                else if (computer == 3)
                {msg = ganar;}
            } 
            // jugador elige papel
            else if (jugador == 2)
            {
                if (computer == 1)
                {msg = ganar;}
                else if (computer == 2)
                {msg = empatar;}
                else if (computer == 3)
                {msg = perder;}
            }
            // jugador elige tijera
            else if (jugador == 3)
            {
                if (computer == 1)
                {msg = perder;}
                else if (computer == 2)
                {msg = ganar;}
                else if (computer == 3)
                {msg = empatar;}
            }
            else
            {
                msg = err;
            }
            
            return msg;
        
	    }
    }
}