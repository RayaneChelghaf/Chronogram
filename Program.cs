// See https://aka.ms/new-console-template for more information

using NAudio.Wave;

Console.WriteLine("Hello, World!");

var fileStream = File.Open(@"C:\Users\Rayane\Desktop\dépot temp\Chronogramme\test.wav", FileMode.Open);

WaveFileReader reader = new WaveFileReader(fileStream) ;

int count = 0;

float[] lastValue = null; 

while (true)
{
    var res = reader.ReadNextSampleFrame();

    if (count++ % 1000 == 0)
        Console.WriteLine(count);

    if (res != null)
        lastValue = res; 

    if (res == null)
        break; 
}






Console.WriteLine();