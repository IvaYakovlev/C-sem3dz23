// Напишите программу которая принимает
// на вход число (N) и выдает таблицу кубов чисел от 1 до N

Console.WriteLine ("Результаты возведения в 3-ю степень скольки чисел хотите видеть?");
int x=int.Parse (Console.ReadLine());
int i=1;
if (x<0){
  i=x;
  x=-1; // х=-1*х
}
for (;i<=x; i++){
  Console.Write ($"{Math.Pow(i,3)} ");
}