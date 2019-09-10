using System;

namespace sap1{
    static class funcs{
        static public bool[] msb(bool[] inp){
            bool[] output = new bool[4];
            for(int n = 4; n < 8; n++){
                output[n-4] = inp[n];
            }
            return output;
        }
    }
}
