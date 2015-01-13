namespace _04.PathAndSave
{
    using System.IO;
    using _01.StructurePoint3D;
    
    static class PathStorage
    {
        static public void Save(Path data, string filePath)
        {
            StreamWriter writer = new StreamWriter(@filePath);
            writer.WriteLine(data.ToString());
            writer.Close();
        }

        static public Path Load(string filePath)
        {
            StreamReader reader = new StreamReader(@filePath);
            string pathString = reader.ReadLine();
            reader.Close();
            
            char[] splitters = new char[] { ',', ' ', '{', '}' };
            string[] points = pathString.Split(splitters, System.StringSplitOptions.RemoveEmptyEntries);
            
            decimal[] coords = new decimal[3];

            Path result = new Path();

            for (int i = 0; i < points.Length; i++)
            {
                coords[0] = decimal.Parse(points[i]);
                i++;
                coords[1] = decimal.Parse(points[i]);
                i++;
                coords[2] = decimal.Parse(points[i]);

                // adding newly-constructed 3-D point to path

                result.AddPoint(new Point3D(coords[0], coords[1], coords[2]));
            }
            
            return result;
        }
            
    }
}
