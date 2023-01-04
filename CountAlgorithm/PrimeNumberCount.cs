// 소수의 개수를 구하는 알고리즘
/*
using System;

class PrimeNumberCount{
    static void Main(){
        // Input
        var count = 0;  // 소수 개수
        var sw = true;  // 소수라면 true를 리턴하는 스위치 변수
        var number = 0; // 2 ~ number까지의 수 중 소수를 구하기 위한 범위
        Console.Write("수 입력 : _\b");
        number = Convert.ToInt32(Console.ReadLine());

        // Process
        for(int i = 2; i <= number; i++){// 2부터 n까지 반복
            
            sw = true;  // 우선 모든 수는 소수로 취급

            // 2부터 i-1까지 나누었을 때 나머지가 0이 나올 경우 소수가 아님.
            for(int j = 2; j < i; j++){
                if(i % j == 0){
                    sw = false;
                    break;
                }
            }
            if(sw){
                Console.Write($"{i}\t");// 소수 출력
                count++;
                if(count % 5 == 0)
                    Console.WriteLine();// 즐바꿈
            }
            
        }
        // Output
        Console.WriteLine($"\n2부터 {number}까지의 소수의 개수 : {count}");
    }
}
*/