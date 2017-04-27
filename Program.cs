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


//foreach
/*
using System;
class foreachdemo{
	static void Main(){
		int sum=0;
		int[] nums=new int[10];
		
		for(int i=0;i<10;i++)
			nums[i]=i;
		
		foreach (int x in nums) {
			Console.WriteLine("Значение элемента равно " + x);
			sum+=x;
		}
		Console.WriteLine("Cумма равна "+ sum);
		
		Console.ReadKey();
	}
}
*/

//foreach demo для двумерных массивов
/*
using System;
class foreachdemo2{
	static void Main(){
		int sum=0;
		int[,] nums=new int[4,2];
		
		for(int i=0;i<4;i++)
			for(int j=0;j<2;j++)
				nums[i,j]=(i+1)*(j+1);
		
		foreach (int x in nums) {
			Console.WriteLine("Значение элемента равно " + x);
			sum+=x;
		}
		Console.WriteLine("Cумма равна "+ sum);
		
		Console.ReadKey();
	}
}
*/

//foreach для поиска
/*using System;
class search{
	static void Main(){
		
		Console.WriteLine("Задайте длину массива ");
		int l=Convert.ToInt32(Console.ReadLine());
		int[] nums=new int[l];
		int val;
		bool found=false;
		
		for(int i=0;i < l;i++)
			nums[i]=i;
		
		for (int i = 0; i < l; i++) 
		{
			Console.WriteLine(nums[i]);
		}
		
		Console.WriteLine("Задайте значение, которое нужно найти ");
		val=Convert.ToInt32(Console.ReadLine());
		
		
		
		
		foreach (int x in nums) 
		{
			if(x==val)
			{
				found=true;
				break;
			}
		}
		if(found)
		{
			Console.WriteLine("Значение "+ val+ " найдено в массиве чисел");
		}
		
		else
		{
			Console.WriteLine("Значение "+ val+ " не найдено в массиве чисел");
		}
		
		Console.ReadKey();
	}
}
*/

//Строки
/*
using System;
using System.Globalization;

class strings{
	static void Main(){
	
		string s1 ="C# is great for .NET";
		string s2= "C# is great for .NET";
		string s3= "Strings in C# are great!";
		string sUp, sLow;
		int res, ind;
		
		Console.WriteLine("First string is: "+s1);
		Console.WriteLine("Lenght of first string is "+s1.Length);
		
		//Тестим прописные и строчные буквы в строках.
		
		sUp=s1.ToUpper(CultureInfo.CurrentCulture);
		sLow=s2.ToLower(CultureInfo.CurrentCulture);
		Console.WriteLine("First string upper reg: "+sUp);
		Console.WriteLine("First string lower reg: "+sLow);	
		Console.WriteLine();
		
		//Посимвольный вывод
		
		Console.WriteLine("Посимвольный вывод: " );
		for(int i=0; i<s1.Length; i++)
		{
			Console.Write(s1[i]);
		}
		Console.WriteLine("\n");
		
		//Сравниваем строки:
		
		if(s1==s2)
			Console.WriteLine("s1==s2");
		else
			Console.WriteLine("s1!=s2");
		
		if(s1==s3)
			Console.WriteLine("s1==s3");
		else
			Console.WriteLine("s1!=s3");
		
		//Сравнение с учетом культурной среды
		
		res=string.Compare(s3,s1,StringComparison.CurrentCulture);
		if(res==0)
			Console.WriteLine("s1=s3");
		else if(res<0)
			Console.WriteLine("s1<s3");
		else
			Console.WriteLine("s1>s3");
		Console.WriteLine();
		
		//Присвоение s2 нового значения
		
		s2="one two three one";
		
		//Поиск подстроки
		
		ind=s2.IndexOf("one", StringComparison.Ordinal);
		Console.WriteLine("Index of first enter <one> "+ind);
		ind=s2.LastIndexOf("one", StringComparison.Ordinal);
		Console.WriteLine("Index of last enter <one> "+ind);
		
		Console.ReadKey();
	}

}
*/

//Массивы строк, программа для вывода цифр числа отдельными словами
/*
using System;

class talk{
	static void Main(){
		int num,nextigit,numdigit;
		int[] n= new int[20];
		string[] s={"zero","one", "two", "three", "four",
			"five", "six", "seven","eight", "nine"};
		
		Console.WriteLine("Enter the number: ");
		num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Number is: "+ num);
		Console.Write("Number by words: ");
		
		nextigit=0;
		numdigit=0;
		//получим отдельные цифры и сохраним в массив(сохраняются в обратном порядке) 
		do
		{
			nextigit=num%10;
			n[numdigit]=nextigit;
			numdigit++;
			num=num/10;
		}
		while (num>0);
		numdigit--;
		
		for( ; numdigit >= 0; numdigit--)
			Console.Write(s[n[numdigit]] + " ");
		Console.WriteLine();
		Console.ReadKey();
	}
}
*/


//Метод Substring
/*
using System;
class SubStr {
	static void Main() {
		string orgstr = "В C# упрощается обращение со строками.";
		// сформировать подстроку
		string substr = orgstr.Substring(5, 20);
		Console.WriteLine("orgstr: " + orgstr);
		Console.WriteLine("substr: " + substr);
		Console.WriteLine("Set substr: ");
		Console.WriteLine("Set begin: ");
		int b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Set end: ");
		int e=Convert.ToInt32(Console.ReadLine());
		string nsubstr = orgstr.Substring(b, e);
		Console.WriteLine("Sew substr: "+nsubstr);
		Console.ReadKey();
	}
}
*/

//foreach в строках

using System;

class foreachstr{
	 static void Main(){
		string[] st={"one","two","three","two","one"};
		
		foreach (string s in st) {
			switch (s) {
				case "one":
					Console.Write("1");
					break;
				case "two":
					Console.Write("2");
					break;
				case "three":
					Console.Write("3");
					break;
			}
		}
		Console.WriteLine();
		Console.ReadKey();
	}
}
