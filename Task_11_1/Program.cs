using System;

namespace Task_11_1
{
	class Array
	{
		private double[][] doubleArray;
		private int n, m;

		public int countArray
		{
			get
			{
				return n * m;
			}
		}
		public int scalarArray
		{
			set
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						doubleArray[i][j] += value;
					}
				}
			}
		}

		public Array(int n, int m)
		{
			this.n = n;
			this.m = m;
			doubleArray = new double[n][];
			for (int i = 0; i < n; i++)
			{
				doubleArray[i] = new double[m];
			}
		}

		public void SetArrayElement()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					doubleArray[i][j] = Convert.ToDouble(Console.ReadLine());
				}
			}
		}

		public void GetArrayElement()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(doubleArray[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}

		public void SortArrayElement()
		{
			for (int i = 0; i < n; i++)
			{
				for (int k = 0; k < m; k++)
				{
					for (int j = 0; j < m - 1; j++)
					{
						if (doubleArray[i][j] < doubleArray[i][j + 1])
						{
							double temp = doubleArray[i][j];
							doubleArray[i][j] = doubleArray[i][j + 1];
							doubleArray[i][j + 1] = temp;
						}
					}
				}
			}
		}

		class Programm
		{
			static void Main()
			{
				try
				{
					Console.WriteLine("Введите размер массива");
					Console.Write("n = ");
					int n = Convert.ToInt32(Console.ReadLine());
					Console.Write("m = ");
					int m = Convert.ToInt32(Console.ReadLine());

					if (n < 1 || m < 1)
					{
						throw new Exception();
					}

					Array doubleArray = new Array(n, m);

					Console.WriteLine("\nВведите элементы массива0");
					doubleArray.SetArrayElement();
					Console.WriteLine();
					doubleArray.GetArrayElement();
					Console.WriteLine("\nСортировка массива");
					doubleArray.SortArrayElement();
					doubleArray.GetArrayElement();
					Console.Write("\nВведите скаляр: ");
					int scalar = Convert.ToInt32(Console.ReadLine());
					doubleArray.scalarArray = scalar;
					Console.WriteLine("\nМассив, умноженный на скаляр");
					doubleArray.GetArrayElement();
					Console.WriteLine("\nКол-во элеметов в массиве: " + doubleArray.countArray);
				}
				catch (FormatException)
				{
					Console.WriteLine("Введите верный формат");
				}
				catch
				{
					Console.WriteLine("Что-то пошло не так");
				}
			}
		}

	}
}