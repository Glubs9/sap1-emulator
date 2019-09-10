namespace sap1{
    class register{

        public bool[] flipflops = new bool[] {false, false, false, false, false, false, false, false};

        public virtual void output(){
            for (int n = 0; n < 8; n++){
                Bus.bus[n] = flipflops[n];
            }
        }

        public virtual void input(){
            for (int n = 0; n < 8; n++){
                 flipflops[n] = Bus.bus[n];
            }
        }

    }
}
