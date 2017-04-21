//демонстрация массивов в C#

//Свойство Lenght

/*
using System;

namespace darrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n=Convert.ToInt32(Console.ReadLine());
			int[] sample=new int[n];
			int i;
			Console.WriteLine("Lenght of array ="+sample.Length);
			
			
			for(i=0;i<n;i++)
				sample[i]=i;
			
			for(i=0;i<n;i++)
				Console.WriteLine("Sample["+i+"]: "+ sample[i]);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
*/


// Двумерные массивы

/*
using System;

	class TwoD {
		static void Main() {
			int t, i;
			int[,] table = new int[20, 20];
			for(t=0; t < 20; ++t) {
				for(i=0; i < 20; ++i) {
					table[t,i] = (t*20)+i+1;
					Console.Write(table[t,i] + " ");
									 }
						Console.WriteLine();
			}
					Console.Write("Press any key to continue . . . ");
Console.ReadKey(true);
	}
}
*/

//Среднее значение чисел в массиве

/*
using System;

class average{
	static void Main(){
		int[] nums={1,11,41,25,42};
		int avg=0;
		
		for(int i=0; i<5;i++)
			avg=avg+nums[i];
		avg=avg/10;
		
		Console.WriteLine("Среднее значение чисел равно "+avg);
		Console.ReadKey(true);
		
	}
}
*/

//Демонстрация превышения длинны массива

/*
using System;

class error{
	public static void Main(){
		int[] nums=new int[100];
		int i;
		for(i=0;i<1000;i=i+1)
			nums[i]=i;
		for(i=0;i<1000;i=i+1)
			Console.WriteLine(nums[i]);
		Console.ReadKey(true);
	}
}
*/

//Двумерный массив с возможностью задавать количество элементов по вертикали и горизонтали,
//а так же вывод элемента массива по его индексу

/*
using System;

class dd{
	public static void Main(){
		Console.WriteLine("Чтобы создать массив задайте количество элементов по вертикали");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Чтобы создать массив задайте количество элементов по горизонтали");
		int b=Convert.ToInt32(Console.ReadLine());
		
		int v,h;
		int[,] ar= new int[a,b];
		
		for(v=0;v<a;++v){
			for(h=0;h<b;++h){
				ar[v,h]=(v*a)+h+1;
				Console.Write(ar[v,h]+ " ");
			}
			Console.WriteLine();
		}
		
		Console.ReadKey();
		Console.WriteLine("Чтобы обратиться к элементу массива задайте вертикальное значение ячейки");
		int s=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine("Чтобы обратиться к элементу массива задайте вертикальное значение ячейки");
		int w=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(ar[s-1,w-1]);
		Console.ReadKey();
	}
}
*/

//Трехмерный массив
/*
using System;

class ddd{
	public static void Main(){
		
		int[,,] ar= new int[3,3,3];
		int s=0;
		int n=1;
		
		for(int x=0;x<3;x++)
			for(int y=0;y<3;y++)
				for(int z=0;z<3;z++)
					
					ar[x,y,z]=n++;
		s=ar[0,0,0]+ar[1,1,1]+ar[2,2,2];
		Console.WriteLine("Сумма массива по первой диагонали равна "+s);
		Console.ReadKey();
		
	}

}
*/

//Ступенчатый массив

/*
using System;
class j{
	public static void Main(){
		int[][] j=new int[5][];
		j[0]=new int[3];
		j[1]=new int[4];
		j[2]=new int[3];
		j[3]=new int[5];
		j[4]=new int[4];
		
		int i;
		for(i=0;i<3;i++)
			j[0][i]=i;
		for(i=0;i<4;i++)
			j[1][i]=i;
		for(i=0;i<3;i++)
			j[2][i]=i;
		for(i=0;i<5;i++)
			j[3][i]=i;
		for(i=0;i<4;i++)
			j[4][i]=i;
		
		for(i=0;i<3;i++)
			Console.Write(j[0][i]+" ");
		Console.WriteLine();
		for(i=0;i<4;i++)
			Console.Write(j[1][i]+" ");
		Console.WriteLine();
		for(i=0;i<3;i++)
			Console.Write(j[2][i]+" ");
		Console.WriteLine();
		for(i=0;i<5;i++)
			Console.Write(j[3][i]+" ");
		Console.WriteLine();
		for(i=0;i<4;i++)
			Console.Write(j[4][i]+" ");
		
		Console.ReadKey(true);
		
	}
}
  */
 
 //Ссылки на массивы
 
/* 
 using System;
 
 class references{
 	public static void Main(){
 		int i;
 		int[] n1=new int[15];
 		int[] n2=new int[15];
 		
 		for(i=0;i<15;i++)
 			n1[i]=i;
 		for(i=0;i<15;i++)
 			n2[i]=-i;
 		Console.Write("Содержимое первого массива: ");
 		for(i=0;i<15;i++)
 			Console.Write(n1[i]+ " ");
 		Console.WriteLine();
 		Console.Write("Содержимое второго массива: ");
 		for(i=0;i<15;i++)
 			Console.Write(n2[i]+ " ");
 		
 		n2=n1;
 		Console.Write("\nСодержание второго массива \n" + "после присваивания :");
 		for(i=0;i<15;i++)
 		Console.Write(n2[i]+ " ");
 		
 		n2[6]=42;
 		Console.Write("\nСодержание первого массива \n" + 
 		              "после присваивания и замены шестого элемента:");
 		for(i=0;i<15;i++)
 		Console.Write(n1[i]+ " ");
 		
 		
 		Console.ReadKey();
 	}
 }
 */
 
 //Неявно типизированный ступенчатый массив
 
 /*
using System;
class Jagged {
  static void Main() {
		var jagged = new[] {
		 new[] { 1, 2, 3, 4 },
		 new[] { 9, 8, 7 },
		 new[] { 11, 12, 13, 14, 15 }
		};
		for(int j = 0; j < jagged.Length; j++) {
			for(int i=0; i < jagged[j].Length; i++)
				Console.Write(jagged[j][i] + " ");
			Console.WriteLine();
		}
		Console.ReadKey(true);
	}
}
*/