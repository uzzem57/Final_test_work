string [] array = {"hello", "2", "word", ":-)"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if ( array[i].Length <=3){
        
        count++;
    }
}
string[] arrayresult = new string[count];
int data = 0;
for (int i = 0; i < array.Length; i++)
{
    if ( array[i].Length <=3){
        arrayresult[data] = array[i];
        data++;
    }
}
Console.WriteLine(String.Join(", ", arrayresult));
