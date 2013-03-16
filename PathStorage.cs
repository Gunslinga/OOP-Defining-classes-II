using System;
using System.IO;

public static class PathStorage
{
    const string PATH = "../../paths.txt";

    public static void WritePathToFile(Path path)
    {
        StreamWriter writer = new StreamWriter(PATH, true);

        using (writer)
        {
            for (int i = 0; i < path.Points.Count; i++)
            {
                writer.Write("{0},{1},{2}|", path.Points[i].X, path.Points[i].Y, path.Points[i].Z);
            }
            writer.WriteLine();
        }
    }

    public static string ReadFromFile(int lineNumber)
    {
        StreamReader reader = new StreamReader(PATH);
        int currentLineNumber = 0;

        using (reader)
        {
            for (string currentLine; (currentLine = reader.ReadLine()) != null; currentLineNumber++)
            {
                if (currentLineNumber == lineNumber)
                {
                    return currentLine;
                }
            }
            throw new IndexOutOfRangeException();
        }
    }
}

