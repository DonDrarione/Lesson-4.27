var A = (Console.ReadLine());
var sum = 0;            
for (int i = 0; i < A.Length; i++) //смотрим на позицию цифры 
{
    sum += Convert.ToInt32 (A[i].ToString()); //берем по одной цифре, преобразуем в Int32 и складываем, так как char при преобразовании выдает id, принудильно преобразовываем в string
}
Console.WriteLine(sum);