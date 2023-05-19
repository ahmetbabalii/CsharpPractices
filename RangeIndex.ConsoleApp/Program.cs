
var numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("\n {0, 1, 2, 3, 4, 5, 6, 7, 8, 9} \n ");

// İlk değeri almak için izlenen yol lar
var first = numbers[0];
first = numbers.First();


// İlk 5 değeri almak için izlenen yol
var target = new int[5];
Array.Copy(numbers, target, 5);


// Sondan başlayarak 1 index'i geriye dön. Sondan başlarken 0'ı index yoktur.
// Sonuç: 9
Index index = new(1, true);
first = numbers[index];
Console.WriteLine($"new Index(1, true) => {first}");


// Baştan başlayarak 1 index'i geriye dön. 
// Sonuç: 1
index = new Index(1);
first = numbers[index];
Console.WriteLine($"new Index(1) => {first}");


// Sondan başlayarak 1 index'i geriye dön. Sondan başlarken 0'ı index yoktur.
// Sonuç: 9
index = Index.FromEnd(1);
first = numbers[index];
Console.WriteLine($"Index.FromEnd(1) => {first}");


// Sondan başlayarak 2 index'i geriye dön. Sondan başlarken 0'ı index yoktur.
// Sonuç: 8
first = numbers[^2];
Console.WriteLine($"numbers[^2] => {first}");


/* 
    Range işlemi mevcut listeyi bire bir kopyalar. Value tipte yeni bir eleman oluşturur.
    Bu yüzden yeni bir eleman oluşturulurken, yeni bir bellek alanı oluşturulur.
 */

// Normal koşullarda constructor da Index beklerken integer gönderebiliyoruz.
// Bunun sebebi Index sınıfında Index implicit olarak tanımlanmış olmasıdır.
// Buda otomatik olarak cast edecebileği anlamına geliyor.
// Sonuç: 1,2
Range range = new(1, 3);
var rangeArr = numbers[range];
Console.WriteLine($"Range range = new(1, 3) => {string.Join(",", rangeArr)}");


// 6. index'den başlayarak en sona kadar yazmasını bekliyoruz.
// Sonuç: 6,7,8,9
range = Range.StartAt(6);
rangeArr = numbers[range];
Console.WriteLine($"range = Range.StartAt(1) => {string.Join(",", rangeArr)}");


// 0. indexden başla ve 4.index'e kadar git
// Sonuç: 0,1,2,3
range = Range.EndAt(4);
rangeArr = numbers[range];
Console.WriteLine($"range = Range.EndAt(4) => {string.Join(",", rangeArr)}");


// .. => Bir range tanımı yapar. 2. index'den başla 5. index'e kadar git.
// 2 ile 5 arasında ki değerleri geriye döner
// Sonuç: 2,3,4
rangeArr = numbers[2..5];
Console.WriteLine($"rangeArr = numbers[2..5] => {string.Join(",", rangeArr)}");


// .. => Bir range tanımı yapar. 
// 2. index'den başla sonran 2. index'e kadar sırala
// Sonuç: 2,3,4,5,6,7
rangeArr = numbers[2..^2];
Console.WriteLine($"rangeArr = numbers[2..^2] => {string.Join(",", rangeArr)}");


Console.ReadLine();