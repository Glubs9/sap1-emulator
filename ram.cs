using System.Collections.Generic;
using System;
using System.Linq;

namespace sap1{
    class Ram : register{

        public Dictionary<bool[], bool[]> ram = new Dictionary<bool[], bool[]>(new MyEqualityComparer());

        public Ram(){
            bool[] test = new bool[]{false, false, false, false};
            for (int n = 0; n < 16; n++){
                ram[test.Select(i => i).ToArray()] = new bool[]{false, false, false, false, false, false, false, false};
                test = ProgramCounter.AddOne(test, 3);
            }
        }

        public override void output(){
            Bus.bus = ram[funcs.msb(flipflops)];
        }

        public void program(bool[] address, bool[] data){
            ram[address] = data;
        }
        
        public void print(){
            foreach (KeyValuePair<bool[], bool[]> outs in ram){
                Console.Write(" ");
                Console.WriteLine();
            }
        }

        public static void outboolarr(bool[] inp, int size){
            for (int n = 0; n <= size; n++){
                Console.Write(inp[n] ? 1 : 0);
            }
        }

        public class MyEqualityComparer : IEqualityComparer<bool[]>
        {
            public bool Equals(bool[] x, bool[] y)
            {
                if (x.Length != y.Length)
                {
                    return false;
                }
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] != y[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public int GetHashCode(bool[] obj)
            {
                int result = 17;
                for (int i = 0; i < obj.Length; i++)
                {
                    unchecked
                    {
                        result = result * 23 + (obj[i] ? 1 : 0);
                    }
                }
                return result;
            }
        }

    }
}
