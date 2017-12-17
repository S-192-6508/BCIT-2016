#light
module MyNamespace.MyModule
open System

printfn "Enter value for first parameter"
let A = Console.ReadLine()
let a = Convert.ToInt32(A)
printfn "Enter value for second parameter"
let B = Console.ReadLine()
let b = Convert.ToInt32(B)
printfn "Enter value for third parameter"
let C = Console.ReadLine()
let c = Convert.ToInt32(C)

let Answ101_1(a1,c1) = Math.Sqrt(Math.Abs(-float(c1)/float(a1)))                                       // a<0 b=0 c>0 || a>0 b=0 c<0 
let Answ101_2(a1,c1) = Math.Sqrt(Math.Abs(float(c1)/float(a1)))                                        // a>40 b=0 c>0 || a<0 b=0 c<0 
let Answ011(b1,c1) = -float(c1)/float(b1)                                                              // a=0 b<>0 c<>0
let Answ110(a1,b1) = -float(b1)/float(a1)                                                              // a<>0 b<>0 c=0
let Disc(a1,b1,c1) = b1*b1-4*a1*c1
let Answ111_1_1(a1,b1,c1) = -float(b1)/float(a1*2) + float(Disc(a1,b1,c1))/float(a1*2)                 // D>0
let Answ111_1_2(a1,b1,c1) = -float(b1)/float(a1*2) - Math.Sqrt(float(Disc(a1,b1,c1)))/float(a1*2)      // D>0
let Answ111_2_Re(a1,b1,c1) = -float(b1)/float(a1*2)                                                    // D=0 && D<0
let Answ111_2_Im(a1,b1,c1) = Math.Sqrt(float(-Disc(a1,b1,c1)))/float(a1*2)                             // D<0

printfn "Entered values: a = %i, b = %i, c = %i" a b c
if(a=0)&&(b=0)&&(c=0) then printfn "x - any value"                                                     //000
if (a=0)&&(b=0)&&not(c=0) then printfn "No roots"                                                      //001
if (a=0)&&not(b=0)&&(c=0) then printfn "x = 0"                                                         //010
if (a=0)&&not(b=0)&&not(c=0) then  printf "x = %f" (Answ011(b,c))                                      //011
if not(a=0)&&(b=0)&&(c=0) then printfn "x1 = x2 = 0"                                                   //100
if (a>0)&&(b=0)&&(c<0) then printfn "x = +-%f" (Answ101_1(a,c))                                        //101 1
if (a<0)&&(b=0)&&(c>0) then printfn "x = +-%f" (Answ101_1(a,c))                                        //101 1
if (a<0)&&(b=0)&&(c<0) then printfn "x = +-%f i" (Answ101_2(a,c))                                      //101 2
if (a>0)&&(b=0)&&(c>0) then printfn "x = +-%f i" (Answ101_2(a,c))                                      //101 2
if not(a=0)&&not(b=0)&&(c=0) then printfn "x1 = 0; x2 = %f" (Answ110(a,b))                             //110
if not(a=0)&&not(b=0)&&not(c=0)&&(Disc(a,b,c)>0) then printfn "x1 = %f; x2 = %f" (Answ111_1_1(a,b,c))(Answ111_1_2(a,b,c))
if not(a=0)&&not(b=0)&&not(c=0)&&(Disc(a,b,c)=0) then printfn "x1 = x2 = %f" (Answ111_2_Re(a,b,c))
if not(a=0)&&not(b=0)&&not(c=0)&&(Disc(a,b,c)<0) then printfn "x = %f +- %f i" (Answ111_2_Re(a,b,c))(Answ111_2_Im(a,b,c))
Console.ReadKey(true)