using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CheckRibbon
{
    class Tuple
    {
        public Tuple(long id, String name, String file) { m_id = id; m_name = name; m_file = file; }
        public long m_id;
        public String m_name;
        public String m_file;
    }

    class Symbols
    {
        public Dictionary<long, Tuple> symbols = new Dictionary<long, Tuple>();
        public bool load(String file, ref List<String> errors, ref List<String> warnings)
        {
            if (String.IsNullOrEmpty(file)) return false;

            warnings.Add(String.Format(@"scanning file ""{0}""", file));

            string[] lines = System.IO.File.ReadAllLines(file);

            bool skip = false;

            foreach (string line in lines)
            {
                String pad = line.Trim();

                if (pad.StartsWith(@"//")) continue;

                if (skip)
                {
                    if (pad.Contains(@"*/")) skip = false;
                    continue;
                }
                else
                {
                    if (pad.StartsWith(@"/*"))
                    {
                        skip = true;
                        continue;
                    }
                }

                if (pad.Contains("#define"))
                {
                    pad = pad.Replace("#define", "").Trim();
                    pad = pad.Replace("\t", " ");


                    while (pad.Contains("  "))
                        pad = pad.Replace("  ", " ");

                    List<String> parts = pad.Split(' ').ToList();
                    if (parts.Count != 2) continue;

                    String symbol = parts[0].ToUpper();

                    long n = ConvertString2Long(parts[1]);
                    if(n != long.MaxValue)
                    {
                        Console.WriteLine(String.Format("{0} {1}", symbol, n));

                        if(getTupleFromSymbol(symbol) != null)
                        {
                            warnings.Add(String.Format(@"symbol ""{0}"" is duplicated in ""{1}""",symbol, file));
                        }
                        else
                        {
                            Tuple t = getTupleFromID(n);
                            if (t == null)
                            {
                                symbols.Add(n, new Tuple(n, symbol, Path.GetFileName(file)));
                            }
                            else
                            {
                                warnings.Add(String.Format(@"""{0}""={1} is a duplicate of ""{2}""={1} in file ""{3}""", symbol, n,  t.m_name, t.m_file));
                            }
                        }
                    }
                }
            }

            return true;
        }

        public Tuple getTupleFromSymbol(String name)
        {
            if (String.IsNullOrEmpty(name))
                return null;


            foreach (KeyValuePair<long, Tuple> symbol in symbols)
            {
                if (symbol.Value.m_name == name)
                    return symbol.Value;
            }
            return null;
        }

        public Tuple getTupleFromID(long id)
        {
            if (!symbols.ContainsKey(id))
                return null;

            return symbols[id];
        }

        static long ConvertString2Long(String s)
        {
            try
            {

                if (String.IsNullOrEmpty(s)) return long.MaxValue;

                String pad = s;
                if (pad.StartsWith("0x"))
                {
                    if (pad.EndsWith("L"))
                    {
                        pad = pad.Remove(pad.Length - 1);
                    }

                    return Convert.ToInt64(pad, 16);
                }

                return Convert.ToInt64(pad, 10);
            }
            catch(Exception ex)
            {
                return long.MaxValue;
            }
        }
    }
}
