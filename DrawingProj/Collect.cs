using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Drawing
{
    class Collect
    {
        List<Shape> shapes = new List<Shape>();
        BinaryFormatter bf = new BinaryFormatter();
        
        private new static Collect collection;
        private Collect(){}
        public static Collect getCollection()
        {
            if (collection == null)
            {
                collection = new Collect();
            }
            return collection;
        }

        public void Add(Shape s)
        {
            shapes.Add(s);
        }
        public void Clear()
        {
            shapes.Clear();
        }
        public Shape Touch(float x, float y)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Touch(x, y))
                {
                    return shapes[i];
                }
            }
            return null;
        }
        public int Count()
        {
            return shapes.Count();
        }
        public void Remove(Shape s)
        {
            shapes.Remove(s);
        }
        public void Save(string path)
        {
            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                bf.Serialize(fstream, shapes);
            }
        }
        public void Load(string path)
        {
            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                shapes = (List<Shape>)bf.Deserialize(fstream);
            }
        }
        public void Draw(Graphics G)
        {
            foreach (Shape i in shapes)
                i.Draw(G);
        }
    }
}
