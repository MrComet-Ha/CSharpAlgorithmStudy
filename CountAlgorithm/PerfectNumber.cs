// 완전수를 구하는 알고리즘
// 완전수 : 자신을 제외한 약수의 합이 자신과 같은 수

using System;

class PerfectNumber{
    static void Main(){
        //Input
        int sum = 0;    // 약수의 합계
        int cnt = 0;    // 완전수의 개수
        int max = 0;    // 가장 큰 약수
        int rem = 0;    // 나머지 값 임시 보관 변수

        //Process
        for(int i = 1; i <= 10000; i++){
            sum = 0;
            max = i / 2;        //모든 짝수를 2로 나눌 때, 가장 큰 약수를 구할 수 있다.
            for(int j = 1; j <= max; j++){
                rem = i % j;
                if (rem == 0){
                    sum += j;   //약수의 합계
                }
            }
            if (i == sum){
                Console.WriteLine("완전수 : {0}", i);
                cnt++;
            }
        }

        //Output
        Console.WriteLine("완전수의 개수 : {0}", cnt);
    }
}