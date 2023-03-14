using tabuleiro;
using jogo;

namespace xadrez
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{

				Tabuleiro tab = new Tabuleiro(8, 8);

				// PosicaoXadrez pos = new PosicaoXadrez('f', 8);
				// Console.WriteLine(pos);
				// Console.WriteLine(pos.toPosicao());

				tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
				// tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
				tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
				tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

				tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 3));
				tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 3));
				tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 1));

				Tela.imprimirTabuleiro(tab);

				Console.ReadLine();
			}
			catch (TabuleiroException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}