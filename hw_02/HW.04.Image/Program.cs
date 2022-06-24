StreamReader textReader = new StreamReader(@"D:\Work\C#\image.txt", true); //Programm find and get our text file
string textReaderResult = textReader.ReadToEnd(); // Reading all characters we have in text file and returns as string
string[] arrayOfTextResult = textReaderResult.Split(' ');//Spliting all our characters as "' '"
byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];//Get all characters in our Array

for (int i = 0; i < arrayOfTextResult.Length - 1; i++)//Converting all our characters in Array to binary
{
    byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
    imageBytes[i] = binary;
}
File.WriteAllBytes(@"D:\Work\C#\hw_dotnet\hw_02\HW.04.Image\image\image.png", imageBytes);//Creating new file with photo
textReader.Dispose();//Stops all resources for text Reader
