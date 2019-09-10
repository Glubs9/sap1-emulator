using System;

namespace sap1{
    class main{
        public static void Main(string[] args){
            Ram r = new Ram();
            ProgramCounter pc = new ProgramCounter();
            register A = new register();
            register B = new register();
            OutputRegister or = new OutputRegister();
            Alu alu = new Alu(A, B);
            Controller c = new Controller(pc, r, A, B, alu, or);
            bool[] address = new bool[]{false, false, false, false};
            bool[] data;
            while (true){
                address = new bool[4];
                data = new bool[8];
                Console.WriteLine("enter address in ram");
                for (int n = 0; n < 4; n++){
                    address[n] = (Console.ReadLine() == "1" ? true : false);
                }
                Console.WriteLine("address entered in ram ");
                Console.WriteLine("enter intstruction");
                for (int n = 0; n < 8; n++){
                    if (n == 4){
                        Console.WriteLine("instruction entered (or most significant 4 bits for data entry)"); 
                        Console.WriteLine("enter address in ram of data (or least significant 4 bits for data entry) (enter 1010 to exit the code)");
                    }
                    data[n] = (Console.ReadLine() == "1" ? true : false);
                }
                Console.WriteLine("data entered (or least significant 4 bits for data entry)");
                if (data[4] && !data[5] && data[6] && !data[7]){ break; }
                r.program(address, data);
            }

            c.start();

        }
    }
}
