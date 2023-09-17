string[] array = {"j","-2", "Russia", "Denmark", "Kazan", "5", ":-)", "ЬПР", "moon"};

string[] newarray = new string[array.Length];



int length = 3;
int newlengtharray = 0;
for (int i = 0; i < array.Length; i++)
{
     if (array[i].Length <= length)
    {
        newarray[newlengtharray] = array[i];
        newlengtharray++;
        
    }
}
string[] finalarray = new string[newlengtharray];
for (int j = 0; j < finalarray.Length; j++)
{
    finalarray[j] = newarray[j];
}
System.Console.WriteLine("[{0}]" ,string.Join(",", finalarray));
