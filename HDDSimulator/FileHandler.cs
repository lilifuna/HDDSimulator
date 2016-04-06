using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDDSimulator;

namespace HDDSimulator
{
    class FileHandler
    {
        public List<Request> ReadFile(String filename)
        {
            List<Request> result = new List<Request>();
            try {
                var reader = new StreamReader(File.OpenRead(ValidateFilename(filename)));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values.Count() == 2)
                    {
                        result.Add(new Request(Convert.ToInt32(values[0]), Convert.ToInt32(values[1])));
                    }
                    else if (values.Count() == 3)
                    {
                        result.Add(new RealTimeRequest(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]), Convert.ToInt32(values[2])));
                    }


                }

                reader.Close();
            }
            catch(FileNotFoundException exception)
            {
                return null;  
            }
            
            return result;
        }
        public String ValidateFilename(String filename)
        {
            String result;
            if (filename.EndsWith(".csv"))
            {
                result = filename;
            }
            else
            {
                result = filename + ".csv";
            }

            return result;
        }
        public void WriteFile(List<Request> requests, String filename)
        {

            try
            {
                var writer = new StreamWriter(File.OpenWrite(ValidateFilename(filename)));

                foreach (Request req in requests)
                {
                    if (req.GetType() == typeof(RealTimeRequest))
                    {
                        RealTimeRequest temp = req as RealTimeRequest;
                        String line = temp.GetPosition() + "," + temp.GetAppearTime() + "," + temp.GetDeadline();
                        writer.WriteLine(line);
                    }
                    else
                    {
                        writer.WriteLine(req.GetPosition() + "," + req.GetAppearTime());
                    }
                }

                writer.Close();

            }
            catch (IOException)
            {

            }
        }
    }
}

