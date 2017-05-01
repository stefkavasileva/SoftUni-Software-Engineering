import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String [] args)
    {
        Scanner scanner = new Scanner(System.in);
        String [] numbersAsStr = scanner.nextLine().split("\\s");

        int[] numbers = new int[numbersAsStr.length];

        for (int i = 0; i < numbersAsStr.length; i++) {
            numbers[i]=Integer.parseInt(numbersAsStr[i]);
        }

        int maxCount = 0;
        int mostFrequentNum = 0;

        for (int i = 0; i < numbers.length; i++) {
            int count = 0;

            for (int j = 0; j < numbers.length; j++) {
                if(numbers[j]==numbers[i]){
                    count++;
                }
            }

            if(count> maxCount){
                maxCount=count;
                mostFrequentNum = numbers[i];
            }

        }

        System.out.println(mostFrequentNum);
    }
}
