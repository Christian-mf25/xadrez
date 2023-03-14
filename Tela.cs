using tabuleiro;
using jogo;

namespace xadrez
{
	class Tela
	{
		public static void imprimirTabuleiro(Tabuleiro tab)
		{
			for (int i = 0; i < tab.linhas; i++)
			{
				Console.Write($"{8 - i} ");
				for (int j = 0; j < tab.linhas; j++)
				{
					if (tab.peca(i, j) == null)
					{
						Console.Write("- ");
					}
					else
					{
						imprimirPeca(tab.peca(i, j));
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			System.Console.WriteLine("  a b c d e f g h");
		}

		public static PosicaoXadrez lerPosicaoXadrez()
		{
			string? s = Console.ReadLine();
			if (!String.IsNullOrEmpty(s))
			{
				char coluna = s[0];
				int linha = int.Parse(s[1] + "");
				return new PosicaoXadrez(coluna, linha);
			}
			return new PosicaoXadrez((char)0, 0);
		}

		public static void imprimirPeca(Peca peca)
		{
			if (peca.cor == Cor.Branca)
			{
				Console.Write(peca);
			}
			else
			{
				ConsoleColor aux = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(peca);
				Console.ForegroundColor = aux;
			}


		}
	}
}