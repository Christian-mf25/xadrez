using tabuleiro;
using jogo;

namespace xadrez
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PosicaoXadrez pos = new PosicaoXadrez('f', 8);
			Console.WriteLine(pos);
			Console.WriteLine(pos.toPosicao());

			Console.ReadLine();
		}
	}
}