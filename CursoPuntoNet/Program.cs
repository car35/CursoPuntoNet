namespace CursoPuntoNet
{
	class Program
	{
        static void Main(string[] args)
		{
			int Pisos = 0;
			int[] Array = new int[1];

			//mostramos un mensaje y capturar elñ dato ingresado desde la consola.

			Console.WriteLine("Ingrese el numero de pisos");
			Pisos = Convert.ToInt16(Console.ReadLine());

			for (int i = 1; i <= Pisos; i++)
			{

				int[] pascal = new int[i];

				for (int j = Pisos; j < i; j--)
				{
					Console.Write("");
				}
				for (int k = 0; k < i; k++)
				{
					if (k == 0 || k == (i - 1))
					{
						pascal[k] = 1;

					}
					else
					{
						pascal[k]= Array[k] + Array[k-1];	
					}

					Console.Write('[' + pascal[k]+']');
				}
				Array = pascal;
				Console.WriteLine(" ");	
			}
            Console.ReadLine();
        }

	}
}