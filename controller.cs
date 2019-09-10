namespace sap1{
    class Controller : register {

        ProgramCounter pc;
        Ram ram;
        register A;
        register B;
        Alu alu;
        OutputRegister or;

        public Controller(ProgramCounter pcin, Ram ramin, register ain, register bin, Alu aluin, OutputRegister orin){
            pc = pcin;
            ram = ramin;
            A = ain;
            B = bin;
            alu = aluin;
            or = orin;
        }
        
        public void start(){
            while (true){
               fetch(); 
               if (!(flipflops[0] || flipflops[1] || flipflops[2] || flipflops[3])){
                   this.output();
                   ram.input();
                   ram.output();
                   A.input();
               }
               else if (!(flipflops[0] || flipflops[1] || flipflops[2]) && flipflops[3]){
                   this.output();
                   ram.input();
                   ram.output();
                   B.input();
                   alu.outputWithSub(false);
                   A.input();
               }
               else if (!(flipflops[0] || flipflops[1] || flipflops[3]) && flipflops[2]){
                   this.output();
                   ram.input();
                   ram.output();
                   B.input();
                   alu.outputWithSub(true);
                   A.input();
               }
               else if (flipflops[0] && flipflops[1] && flipflops[2] && !(flipflops[3])){
                   A.output();
                   or.input();
                   or.output();
               }
               else if (flipflops[0] && flipflops[1] && flipflops[2] && flipflops[3]){
                   break;
               }
            }
        }

        private void fetch(){
            pc.output();
            ram.input();
            pc.input();
            ram.output();
            this.input();
        }

        public override void output(){
             bool[] chang = funcs.msb(flipflops);
             for (int n = 4; n < 8; n++){
                 Bus.bus[n] = chang[n-4];
             }
        }

    }
}
