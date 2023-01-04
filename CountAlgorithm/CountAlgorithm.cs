// 1부터 1,000까지의 정수 중 13의 배수의 개수
/*
using System;
using System.Linq;

class CountAlgorithm{
    static void Main(){
        //Input
        var numbers = Enumerable.Range(1,1_000).ToArray();
        int count = default;
        //Process
        for(int i = 0; i < numbers.Length; i++){
            if(numbers[i] % 13 == 0)
                count++;
        }
        //Output
        Console.WriteLine($"1부터 1,000까지의 정수의 수 : {count}");
    }

    //var numbers = Enumerable.Range(1,1_000).ToArray().Where(n => n % 13 == 0).Count();
    //var numbers = Enumerable.Range(1,1_000).ToArray().Count(n => n % 13 == 0);
    
}

*/