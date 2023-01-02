using System;

/// <summary>
/// 등차수열 합계
/// </summary>
class ArithmeticSequence{
    static void Main(){
        //Input
        var sum = 0;

        //Process
        for(int i = 1; i <= 20; i++){
            if(i % 2 == 1){
                sum += i;
                System.Console.WriteLine("{0, 2} ", i);
            } 
        }
        //Output
        System.Console.WriteLine($"1부터 20까지의 홀수의 합 : {sum}");
    }
}