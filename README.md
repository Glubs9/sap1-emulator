# sap1-emulator
Disclaimer:
I am using Github as a personal library for some fun projects that I can be bothered to upload and as a digital portfolio. This means this is not an actual program and as such I will not accept any changes or anything. If you are extra eager to clean up my shitty code just copy all my files and make sure to credit me.
Also I have no clue how the formatting works. Sorry this is so unreadable.

# Install Instructions
This code is designed to run on linux and I have not tested for windows. Though the compiler/interpreter should work on windows.
If you want to run this code then make sure to have mono installed on your computer. To get this follow the instructions at this website https://www.mono-project.com/download/stable/#download-lin-ubuntu or type into a console (in a debian based os) sudo apt-get install mono-devel. 
Then download all the files onto your computer. run make (./make) in the folder and it should compile and run!
(Note: for windows this might not work, it might but probably not.)
from this point on if you want to run the code you can just run run.exe (using mono on linux or doing something else for windows)

# Context
This was designed to emulate the SAP1(simple as possible) design specification from the book Digital Computer Electronics by Albertt Paul Maldivino. I would recommend reading the book in order to understand how the computer works (I will still include a tutorial on how to use it). The SAP1 design was not intended to be a real practical design just an excerise to get the reader to understand the very basics. I have written this to allow myself to understand the design better and computers as a whole! This design isn't very well written (I am sick) but I had fun doing it anyway. I also haven't added the asynchronus nature of a real computer because it runs in a very linear fashion anyway, due to this I also haven't included a clock of anykind and the emulator will just run as fast as it can. 
Every Instruction is made of two parts, the instruction and the address in ram where you will find the data for the instruction.
An example would be 0000(LDA) 1001(RAM address 1001). 


# Instructions
To use the computer either run the make file or run the run.exe.
To enter data into the ram enter each bit individually (sorry it was easy to code)
It will ask you to input the data in three different steps.
First it will ask for the address in RAM that you will write to (it starts reading the program from RAM address 0000)
Then you will enter one of two things, either the most significant 4 bytes in a number (if you are writing numbers/data to the RAM), or the instruction to run.
Then you will enter one of two things, either the least significant 4 bytes in the same number (if you are writing numbers/data to the RAM), or the address of the RAM where the computer can find the data for your instruction.
It will then repeat from the start.
Once you have entered all the desired data you will input any inputs into the first two stages, then you will input (into the RAM address/least 4 significant bytes) 1010 to get the computer to run the code.
# The Instruction List
0000 = LDA = load the accumulator register with the contents given in the RAM address/3rd set of 4 bytes entered.
0001 = ADD = Add the contents of the RAM address given and set the accumulator register to the answer.
0010 = SUB = Subtract the contents of the RAM address given and set the accumulator register to the answer.
1110 = OUT = Output the contents of the accumulator.
1111 = HLT = Stop the program running (if this is not entered the computer will freak out).
