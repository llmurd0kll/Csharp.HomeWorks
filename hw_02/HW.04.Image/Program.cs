StreamReader textReader = new StreamReader(@"D:\Work\C#\image.txt", true);
string textReaderResult = textReader.ReadToEnd();
string[] arrayOfTextResult = textReaderResult.Split(' ');
byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
{
    byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
    imageBytes[i] = binary;
}
File.WriteAllBytes(@"D:\Work\C#\hw_dotnet\hw_02\HW.04.Image\image\image.png", imageBytes);
textReader.Dispose();
