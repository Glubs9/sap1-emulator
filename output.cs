using System;

namespace sap1{
    class OutputRegister : register {

        public override void output(){
            foreach(bool n in flipflops){
                Console.Write(n ? 1 : 0);
            }
            Console.WriteLine();
        }

    }
}
