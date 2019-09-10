//least significant byte on the right
namespace sap1{
    class ProgramCounter: register{

        public override void input(){
            flipflops = AddOne(flipflops, 7);
        }

        public static bool[] AddOne(bool[] inp, int size){
            bool carry = true;
            bool tmpcarry;
            bool[] output = inp;
            for(int n = size; n >= 0; n--){
                tmpcarry = carry;
                carry = (carry && output[n]);
                output[n] = (tmpcarry != output[n]);
            }
            return output;
        }

    }
}
