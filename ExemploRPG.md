```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
		public static int posicao_num;
		public static string posicao_txt;
		public static int Vida = 100;
		public static int Dano = 25;
		public static int Energia = 20;
		public static int Peitoral;
		public static int Durabilidade_Espada;
		public static int Espada;

		public static void Historia()
		{
			Console.WriteLine("Há um tempo atrás na cidade de Swordfish havia uma mansão que sempre chamava atenção dos moradores.\nSeu dono, um velho altamente misterioso, nunca saia de lá e não recebia visita alguma. Este homem se chamava Rainy");
			Console.ReadLine();
			Console.WriteLine("Os vizinhos observavam encomendas chegando na sua casa, e frequentemente ouviam gritos saindo de la");
			Console.ReadLine();
			Console.WriteLine("por isso começou a circular histórias de que ele fazia experimentos com humanos");

			Console.Clear();
			Console.WriteLine("Algum tempo se passou...");
			Console.ReadLine();
			Console.WriteLine("E Rainy veio a falecer...");
			Console.ReadLine();
			Console.WriteLine("a mansão passou a ficar abandonada, todos que passavam em frente se recusavam até mesmo olhar para ela");
			Console.ReadLine();
			Console.WriteLine("...");
			Console.ReadLine();
			Console.WriteLine("até que um dia, um(a) jovem chamado(a): \n");

			Console.Write("Qual seu nome: ");
			string nome = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("até que um dia, um(a) jovem chamado(a) {0} decidiu entrar e descobrir o mistério", nome);
			Console.ReadLine();
			Console.WriteLine("...");
			Console.WriteLine("mas após entrar, as portas e janelas se fecharam de uma forma inesperada,\n e {0} descobriu que a casa era na verdade maior doque ele(a) esperava\n.Ela tinha muitas salas, e parecia bem confusa, como um labirinto.", nome);
			Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Descubra a saida, antes que seja tarde demais...");
			Console.ReadLine();
		}
		public static void Main()
		{
			int chave = 0;
			int acao;
			int abrir_bau = 0;

			Historia();

			posicao_num = 1;

			while (Vida > 0)
			{
				Console.Clear();
				switch (posicao_num)
				{
					case 1:
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer? ");
						Console.WriteLine("[1]ir para Salão 1");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 2;
						}
						break;

					case 2:
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer? ");
						Console.WriteLine("[1]ir para Sala 1");
						Console.WriteLine("[2]ir para A3");
						Console.WriteLine("[3]ir para B3");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 1;
						}
						else if (acao == 2)
						{
							posicao_num = 3;
						}
						else if (acao == 3)
						{
							posicao_num = 11;
						}
						break;

					case 3:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 1");
						Console.WriteLine("[2]ir para Salão 2");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 2;
						}
						else if (acao == 2)
						{
							posicao_num = 4;
						}
						break;

					case 4:
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer? ");
						Console.WriteLine("[1]ir para A3");
						Console.WriteLine("[2]ir para A4");
						Console.WriteLine("[3]ir para A5");
						Console.WriteLine("[4]ir para Salão 3");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 3;
						}
						else if (acao == 2)
						{
							posicao_num = 5;
						}
						else if (acao == 3)
						{
							posicao_num = 6;
						}
						else if (acao == 4)
						{
							posicao_num = 7;
						}
						break;

					case 5:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = "A4";
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 2");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 4;
						}
						break;

					case 6:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 2");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 4;
						}
						break;

					case 7:
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer? ");
						Console.WriteLine("[1]ir para Salão 2");
						Console.WriteLine("[2]ir para A6");
						Console.WriteLine("[3]ir para A7");
						Console.WriteLine("[4]ir para A8");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 4;
						}
						else if (acao == 2)
						{
							posicao_num = 9;
						}
						else if (acao == 3)
						{
							posicao_num = 10;
						}
						else if (acao == 4)
						{
							posicao_num = 8;
						}
						break;

					case 8:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 3");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 7;
						}
						break;

					case 9:
						if (chave == 0)
						{
							Console.WriteLine("__você encontrou uma chave__");
							chave = 1;
							Console.ReadLine();
						}
						Console.Clear();
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 3");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 7;
						}
						break;

					case 10:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 3");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 7;
						}
						break;
					case 11:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 1");
						Console.WriteLine("[2]ir para B4");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 2;
						}
						else if (acao == 2)
						{
							posicao_num = 12;
						}
						break;

					case 12:
						if (abrir_bau != 3)
						{

							Console.WriteLine("Você achou um cofre");
							Console.WriteLine("[1] Abrir \n[2] Agora não");
							abrir_bau = int.Parse(Console.ReadLine());

							if (abrir_bau == 1)
							{
								if (chave == 1)
								{
									Console.WriteLine("você achou um colete, ele será bem útil daqui pra frente");
									Console.WriteLine("Sua vida subiu: 50hp");
									Vida += 50;
									Console.ReadLine();
									abrir_bau = 3;
								}
								else
								{
									Console.WriteLine("O cofre está trancado");
									Console.WriteLine("a chave está em alguma sala do conjunto (A) ");
									Console.ReadLine();
								}
							}
						}

						Console.Clear();
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para B3");
						Console.WriteLine("[2]ir para Salão 4");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 11;
						}
						else if (acao == 2)
						{
							posicao_num = 13;
						}

						break;

					case 13:
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer? ");
						Console.WriteLine("[1]ir para B4");
						Console.WriteLine("[2]ir para B5");
						Console.WriteLine("[3]ir para B6");
						Console.WriteLine("[4]ir para B7");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 12;
						}
						else if (acao == 2)
						{
							posicao_num = 14;
						}
						else if (acao == 3)
						{
							posicao_num = 15;
						}
						else if (acao == 4)
						{
							posicao_num = 16;
						}
						break;

					case 14:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir Salão 4");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 13;
						}
						break;

					case 15:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir Salão 4");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 13;
						}
						break;

					case 16:
						Combate();
						if (Vida <= 0)
						{
							break;
						}
						posicao_txt = Conv_num_txt(posicao_num);
						func_mapa();
						Console.WriteLine("O que deseja fazer?");
						Console.WriteLine("[1]ir para Salão 4");
						Console.WriteLine("[2]ir para Salão B8");
						acao = int.Parse(Console.ReadLine());
						if (acao == 1)
						{
							posicao_num = 13;
						}
						else if (acao == 2)
						{
							posicao_num = 17;
						}
						break;
					case 17:
						Console.Write("Você consegue achar a saída e desesperadamente corre até ela e consegue sair de lá\nVocê escapou");
						Console.ReadLine();
						break;
				}
			}
		}


		public static void func_mapa()
		{
			string mapa = @" 
			        MAPA:
-----------------------------------------------------------
         A4          sala 1                           
	 |	       |                              
  A5 - Salão2 - A3 - Salão1 - B3 - B4                 
	 |		            |                  
  A6 - Salão3 - A8	    B5 - Salão4 - B6          
         |                          |                  
         A7		            B7                  
			            |                 
			            B8                
-----------------------------------------------------------
            ";

			Console.Clear();
			Console.WriteLine(mapa);
			Console.WriteLine("Vida: {0} Energia {1} Dano {2}", Vida, Energia, Dano);
			Console.WriteLine("Sua posição é: {0}", posicao_txt);

		}

		public static string Conv_num_txt(int x)
		{
			if (x == 1)
			{
				posicao_txt = "Sala 1";
			}
			else if (x == 2)
			{
				posicao_txt = "Salão 1";
			}
			else if (x == 3)
			{
				posicao_txt = "A3";
			}
			else if (x == 4)
			{
				posicao_txt = "Salão 2";
			}
			else if (x == 5)
			{
				posicao_txt = "A4";
			}
			else if (x == 6)
			{
				posicao_txt = "A5";
			}
			else if (x == 7)
			{
				posicao_txt = "Salão 3";
			}
			else if (x == 8)
			{
				posicao_txt = "A8";
			}
			else if (x == 9)
			{
				posicao_txt = "A6";
			}
			else if (x == 10)
			{
				posicao_txt = "A7";
			}
			else if (x == 11)
			{
				posicao_txt = "B3";
			}
			else if (x == 12)
			{
				posicao_txt = "B4";
			}
			else if (x == 13)
			{
				posicao_txt = "Salão 4";
			}
			else if (x == 14)
			{
				posicao_txt = "B5";
			}
			else if (x == 15)
			{
				posicao_txt = "B6";
			}
			else if (x == 16)
			{
				posicao_txt = "B7";
			}
			else
			{
				posicao_txt = "B8";
			}
			return posicao_txt;

		}

		public static void Combate()
		{
			Random rand = new Random();
			int Monstro = rand.Next(1, 4);
			int Sortear_Monstro = rand.Next(1, 3);

			if (Sortear_Monstro == 1)
			{
				switch (Monstro)
				{
					case 1:
						Morcego();
						Energia--;
						Durabilidade_Espada -= 1;
						if (Vida <= 0)
						{
							Console.Clear();
							Console.WriteLine("Você morreu");
							Console.ReadLine();
							break;
						}
						else
						{
							if (Energia > 20)
							{
								Energia = 20;
							}
							if (Energia <= 0)
							{
								Energia = 0;
								Dano -= 10;
								Console.WriteLine("Você está exausto demais para atacar com tudo, seu dano cai para 15");
							}
							if (Espada == 1)
							{
								if (Durabilidade_Espada == 0)
								{
									Espada = 0;
									Dano = 25;
									Console.WriteLine("Sua espada quebrou depois de tantos golpes\nDano -25");
									Console.ReadLine();
								}
							}
						}
						break;
					case 2:
						Slime();
						Energia--;
						Durabilidade_Espada -= 1;
						if (Vida <= 0)
						{
							Console.Clear();
							Console.WriteLine("Você morreu");
							Console.ReadLine();
							break;
						}
						else if (Vida > 0)
						{
							if (Peitoral == 0)
							{
								if (Vida > 100)
								{
									Vida = 100;
								}
							}
							else
							{
								if (Vida > 150)
								{
									Vida = 150;
								}
							}
							if (Energia <= 0)
							{
								Energia = 0;
								Dano -= 10;
								Console.WriteLine("Você está exausto demais para atacar com tudo, seu dano cai para 15");
								Console.ReadLine();
							}
							if (Espada == 1)
							{
								if (Durabilidade_Espada == 0)
								{
									Espada = 0;
									Dano = 25;
									Console.WriteLine("Sua espada quebrou depois de tantos golpes\nDano -25");
									Console.ReadLine();
								}
							}
						}
						break;

					case 3:
						Esqueleto();
						Energia--;
						if (Durabilidade_Espada >= 5)
						{
							Durabilidade_Espada = 5;
						}
						if (Vida <= 0)
						{
							Console.Clear();
							Console.WriteLine("Você morreu");
							Console.ReadLine();
							break;
						}
						if (Espada == 0)
						{
							Dano = 25;
						}
						else if (Espada == 1)
						{
							Durabilidade_Espada += 5;
							if (Dano == 50)
							{
								Dano = 50;
							}
						}
						if (Energia <= 0)
						{
							Energia = 0;
							Dano -= 10;
							Console.WriteLine("Você está exausto demais para atacar com tudo\nDano -10");
							Console.ReadLine();
						}
						break;
				}
			}
		}



		public static void Slime()
		{
			Random rand = new Random();
			int Valor;
			int Numero;
			int NumMaq;
			int Total;
			int Escolha;
			int Vida_Slime = 50;
			int Dano_Slime = 15;

			Console.WriteLine("Você abre a porta e se depara com uma gosma lentamente se aproximando de você\nLutar (1)\nEvitar Luta(2)");
			Escolha = int.Parse(Console.ReadLine());

			switch (Escolha)
			{
				case 1:
					Console.Clear();
					while (Vida_Slime > 0)
					{
						Escolha = 0;
						Valor = 0;

						Console.WriteLine("Seu turno\nÍmpar (1)\nPar (2)");
						Valor = int.Parse(Console.ReadLine());
						if (Valor == 1 || Valor == 2)
						{
							Console.WriteLine("Escolha um número de 0 a 10");
							Numero = int.Parse(Console.ReadLine());
							Console.Clear();
							if (Numero > 0 && Numero <= 10)
							{
								NumMaq = rand.Next(0, 10);
								Total = Numero + NumMaq;
								Console.WriteLine("O seu valor escolhido foi {0}\nO valor escolhido pela Slime foi {1}\nO total deu {2}", Numero, NumMaq, Total);
								if (Total % 2 == 0)
								{
									if (Valor == 2)
									{
										Console.WriteLine("Você desfere um poderoso golpe contra a Slime");
										Vida_Slime -= Dano;
									}
									else if (Valor == 1)
									{
										Console.WriteLine("A Slime usa sua textura gelatinosa para se esquivar do ataque");
									}
									Console.WriteLine("Sua vida: {0}\nVida da Slime: {1}", Vida, Vida_Slime);
									if (Vida_Slime <= 0)
									{
										Console.WriteLine("Você matou o Slime\nVocê percebe que sua gosma não se desfaz completamente, então por estar com muita sede,\nvocê acaba bebendo e percebe que esta gosma era especial");
										Console.WriteLine("Você recuperou 15hp");
										Console.Clear();
										Vida += 15;
										Console.ReadLine();
										break;
									}
									Console.ReadLine();
								}
								else if (Total % 2 != 0)
								{
									if (Valor == 1)
									{
										Console.WriteLine("Você desfere um poderoso golpe contra a Slime");
										Vida_Slime -= Dano;
									}
									else if (Valor == 2)
									{
										Console.WriteLine("A Slime usa sua textura gelatinosa para se esquivar do ataque");
									}
									Console.WriteLine("Sua vida: {0}\nVida da Slime: {1}", Vida, Vida_Slime);
									if (Vida_Slime <= 0)
									{
										Console.WriteLine("Você matou o Slime\nVocê percebe que sua gosma não se desfaz completamente, então por estar com muita sede,\nvocê acaba bebendo e percebe que esta gosma era especial");
										Console.WriteLine("Você recuperou 15hp");
										Console.Clear();
										Vida += 15;
										Console.ReadLine();
										break;
									}
									Console.ReadLine();
								}
							}
							else
							{
								Console.Clear();
								Console.WriteLine("Número digitado não é válido, você perde seu turno");
								Console.ReadLine();
							}
						}
						else
						{
							Console.Clear();
							Console.WriteLine("Valor digitado não é válido, você perde seu turno");
							Console.ReadLine();
						}
						Console.WriteLine("Sua vida: {0}\nVida da Slime: {1}", Vida, Vida_Slime);
						Console.Clear();
						Console.WriteLine("Turno da Slime");
						Escolha = rand.Next(1, 3);
						switch (Escolha)
						{
							case 1:
								Console.WriteLine("A escolha da slime foi ímpar");
								Console.Write("Escolha um número: ");
								Numero = int.Parse(Console.ReadLine());
								NumMaq = rand.Next(1, 11);
								Total = Numero + NumMaq;
								Console.Clear();
								Console.WriteLine("O seu número escolhido foi {2}\nO número escolhido pela slime foi {0}\nA soma deu {1}", NumMaq, Total, Numero);
								if (Total % 2 == 0)
								{
									Console.WriteLine("Você facilmente desvia do lento ataque da slime");
								}
								else
								{
									Console.WriteLine("Você se descuida e é pego pelo ataque da slime");
									Vida -= Dano_Slime;
								}
								Console.WriteLine("Sua vida: {0}\nVida da Slime: {1}", Vida, Vida_Slime);
								break;
							case 2:
								Console.WriteLine("A escolha da slime foi par");
								Console.Write("Escolha um número de 1 a 10: ");
								Numero = int.Parse(Console.ReadLine());
								NumMaq = rand.Next(1, 11);
								Total = Numero + NumMaq;
								Console.Clear();
								Console.WriteLine("O seu número escolhido foi {2}\nO número escolhido pela slime foi {0}\nA soma deu {1}", NumMaq, Total, Numero);
								if (Total % 2 != 0)
								{
									Console.WriteLine("Você facilmente desvia do lento ataque da slime");
								}
								else
								{
									Console.WriteLine("Você se descuida e é pego pelo ataque da slime");
									Vida -= Dano_Slime;
								}
								Console.WriteLine("Sua vida: {0}\nVida da Slime: {1}", Vida, Vida_Slime);
								break;
						}
						Console.ReadLine();
						if (Vida <= 0)
						{
							break;
						}
						Console.Clear();
					}
					break;
				case 2:
					Console.Clear();
					Console.WriteLine("Você facilmente conseguiu fugir da slime");
					break;
			}
		}
		public static void Esqueleto()
		{
			Random rand = new Random();
			int Dado;
			int Escolha;
			int Vida_Esqueleto = 75;
			int Dano_Esqueleto = 25;

			Console.WriteLine("Você abre a porta e vê um esqueleto te encarando, deseja ficar e lutar ou fugir?\nLutar (1)\nFugir (2)");
			Escolha = int.Parse(Console.ReadLine());
			Console.Clear();

			switch (Escolha)
			{
				case 1:
					while (Vida_Esqueleto > 0)
					{
						Escolha = 0;
						Console.WriteLine("Seu turno\nAtacar (1)");
						Escolha = int.Parse(Console.ReadLine());
						Console.Clear();
						Dado = rand.Next(1, 20);
						Console.WriteLine("O seu dado caiu {" + Dado + "}");
						switch (Escolha)
						{
							case 1:
								if (Dado < 13)
								{
									Console.WriteLine("Você errou o ataque");
									Console.WriteLine("Vida do Esqueleto = " + Vida_Esqueleto);
									Console.WriteLine("Sua vida = " + Vida);
									Console.ReadLine();
								}
								else
								{
									Console.WriteLine("Você acerta o ataque com tudo, causando " + Dano + " de dano");
									Vida_Esqueleto -= Dano;

									Console.WriteLine("Vida do Esqueleto = " + Vida_Esqueleto);
									Console.WriteLine("Sua vida = " + Vida);
									Console.ReadLine();
								}
								Escolha = 0;
								Console.Clear();
								if (Vida_Esqueleto <= 0)
								{
									Console.WriteLine("Você matou o esqueleto e ele dropa a sua espada, mas ela parece bastante desgastada\nDano = 50");
									Espada = 1;
									Console.ReadLine();
									break;
								}
								if (Vida <= 0)
								{
									break;
								}
								Console.WriteLine("Turno do Esqueleto");
								Dado = rand.Next(1, 20);
								Console.WriteLine("O esqueleto tirou {" + Dado + "}");
								if (Dado < 15)
								{
									Console.WriteLine("O Esqueleto errou o ataque");
									Console.WriteLine("Vida do Esqueleto = " + Vida_Esqueleto);
									Console.WriteLine("Sua vida = " + Vida);
									Console.ReadLine();
								}
								else
								{
									Console.WriteLine("O Esqueleto acerta o ataque com tudo, causando " + Dano_Esqueleto + " de dano");
									Vida -= Dano_Esqueleto;

									Console.WriteLine("Vida do Esqueleto = " + Vida_Esqueleto);
									Console.WriteLine("Sua vida = " + Vida);
									Console.ReadLine();
								}
								Console.Clear();
								if (Vida <= 0)
								{
									break;
								}
								break;
						}
					}
					break;
				case 2:
					Console.Clear();
					Console.WriteLine("Você sai correndo, aproveitando a distância entre você e o esqueleto\nVocê fugiu com facilidade");
					Console.ReadLine();
					break;
			}
		}
		public static void Morcego()
		{
			Random rand = new Random();
			int Numero;
			int NumMaq;
			int Vida_Morcego = 25;
			int Dano_Morcego = 7;
			int Escolha;


			Console.WriteLine("Você abre a porta e vê um morcego voando em sua direção\nLutar (1)\nFugir (2)");
			Escolha = int.Parse(Console.ReadLine());
			switch (Escolha)
			{
				case 1:
					while (true)
					{
						Console.WriteLine(" 1 é Pedra");
						Console.WriteLine(" 2 é Papel");
						Console.WriteLine(" 3 é Tesoura");
						Console.WriteLine(" Escolha 1, 2 ou 3 ");
						Numero = int.Parse(Console.ReadLine());
						if (Numero >= 1 && Numero <= 3)
						{
							NumMaq = rand.Next(1, 4);
							if (Numero >= 1 && Numero <= 3)
							{
								Console.WriteLine("Você escolheu: " + Numero);
								Console.WriteLine("O Morcego escolheu: " + NumMaq);
							}
							if (Numero == 1)
							{

								if (NumMaq == 1)
								{
									Console.WriteLine("Incrívelmente os dois erraram o ataque");
								}
								else if (NumMaq == 2)
								{
									Console.WriteLine("O Morcego parte pra cima de você e consegue acertar a mordida");
									Vida -= Dano_Morcego;
									Console.WriteLine("Vida do Morcego = " + Vida_Morcego);
									Console.WriteLine("Sua vida = " + Vida);
								}
								else
								{
									Console.WriteLine("Você acerta o Morcego desprevenido, enquanto ele está indo ao ataque");
									Vida_Morcego -= Dano;
									Console.WriteLine("Vida do Morcego = " + Vida_Morcego);
									Console.WriteLine("Sua vida = " + Vida);
								}
							}
							else if (Numero == 2)
							{
								if (NumMaq == 2)
								{
									Console.WriteLine("Incrívelmente os dois erraram o ataque");
								}
								else if (NumMaq == 3)
								{
									;
									Console.WriteLine("O Morcego parte pra cima de você e consegue acertar a mordida");
									Vida -= Dano_Morcego;
									Console.WriteLine("Vida do Morcego = " + Vida_Morcego);
									Console.WriteLine("Sua vida = " + Vida);
								}
								else
								{
									Console.WriteLine("Você acerta o Morcego desprevenido, enquanto ele está indo ao ataque");
									Vida_Morcego -= Dano;
									Console.WriteLine("Vida do Morcego = " + Vida_Morcego);
									Console.WriteLine("Sua vida = " + Vida);
								}
							}
							else
							{
								if (NumMaq == 3)
								{
									Console.WriteLine("Incrívelmente os dois erraram o ataque");
								}
								else if (NumMaq == 2)
								{
									Console.WriteLine("Você acerta o Morcego desprevenido, enquanto ele está indo ao ataque");
									Vida_Morcego -= Dano;
									Console.WriteLine("Vida do Morcego = " + Vida_Morcego);
									Console.WriteLine("Sua vida = " + Vida);
								}
								else
								{
									Console.WriteLine("O Morcego parte pra cima de você e consegue acertar a mordida");
									Vida -= Dano_Morcego;
									Console.WriteLine("Vida do Morcego = " + Vida_Morcego);
									Console.WriteLine("Sua vida = " + Vida);
								}
							}
						}
						else
						{
							Console.WriteLine("Número não identificado");
						}
						Console.ReadLine();
						Console.Clear();
						if (Vida_Morcego <= 0)
						{
							Console.WriteLine("Você matou o Morcego\nE por falta do que comer, você acaba assando e comendo a sua carne\nVocê recuperou energia");
							Energia += 3;
							Console.ReadLine();
							break;
						}
						if (Vida <= 0)
						{
							break;
						}
						Console.Clear();
					}
					break;
				case 2:
					Console.Clear();
					Console.WriteLine("Você consegue desviar do morcego, fazendo com que ele passe direto e te der tempo de correr");
					Console.ReadLine();
					break;
			}

		}
	}
}
