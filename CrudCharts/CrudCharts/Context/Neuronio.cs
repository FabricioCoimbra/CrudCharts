using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCharts.Context
{
	public class Neuronio
	{
		public Double peso;
	}

	public class Camada
	{
		public List<Neuronio> neuronios;
	}

	public class RedeNeural
	{
		public Double bias;

		public Queue<Camada> camadas;
		public List<Double> entradas;
		public List<Double> saidasDesejadas;

		private List<Double> saidas;

		private void FeedFoward(List<Double> entradasCamadaAtual)
		{
			if (camadas.Count > 0)
			{
				Camada camada = camadas.Dequeue();

				saidas.Clear();

				foreach (Double entrada in entradasCamadaAtual)
				{
					Double soma = bias;									

					foreach (Neuronio neuronio in camada.neuronios)
					{
						soma += entrada * neuronio.peso;
					}
					saidas.Add(soma);									
				}
				FeedFoward(saidas);
			}
		}

		public void Treinar(int numeroIteracoes)
		{
			saidas = new List<Double>();
			for(int i = 0; i< numeroIteracoes; i++)
			{
				FeedFoward(entradas);
			}			
		}
	}
}
