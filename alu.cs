using System.Linq;

namespace sap1{
    class Alu : register{

        private register A;
        private register B;

        public Alu(register Ain, register Bin){
            A = Ain;
            B = Bin;
        }

        public void outputWithSub(bool sub){
            flipflops = addbin(A, B, sub);
            base.output();
        }

        private bool[] addbin(register a, register b, bool sub){
            bool carry = false;
            bool[] outp = new bool[]{false, false, false, false, false, false, false, false};
            int aot; //AmountOfTrues

            bool[] btmp = b.flipflops;
            if (sub){ btmp = twosComplement(btmp); }

            for (int n = 7; n >= 0; n--){
                aot = countTrues(a.flipflops[n], btmp[n], carry);
                outp[n] = (aot % 2 != 0);
                carry = (aot > 1);
            }
            return outp;
        }

        private bool[] twosComplement(bool[] inp){
            bool[] output = inp.Select(n => !(n)).ToArray();
            return ProgramCounter.AddOne(output, 7);
        }

        private int countTrues(bool a, bool b, bool c){
            int total = 0;
            if (a){total += 1;}
            if (b){total += 1;}
            if (c){total += 1;}
            return total;
        }

    }
}
