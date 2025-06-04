#!/home/giovaniharada/dotnet-preview/dotnet run
Console.WriteLine("Binary Search Example");
Console.WriteLine("Enter a value to search (1-15):");
var value = int.Parse(Console.ReadLine());
int[] lista = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
var res = findElementBin(lista, value);

Console.WriteLine($"Found value {value} in index {res}");




static int findElementBin(int[] list, int valueToFind) {
  int hops = 0;
  int elIndex = -1;
  int lIn = 0;
  int rIn = list.Length - 1;

  int searchIn = (lIn + rIn) / 2;
  while (lIn <= rIn) {
    if(list[searchIn] == valueToFind){
      elIndex = searchIn;
      break;
    }
    if(valueToFind < list[searchIn]) {
      rIn = searchIn - 1;
    } else {
      lIn = searchIn + 1; 
    }

    searchIn = (lIn + rIn) / 2;
    hops++;
  }
  Console.WriteLine($"Hops: {hops}");
  return elIndex;
}
