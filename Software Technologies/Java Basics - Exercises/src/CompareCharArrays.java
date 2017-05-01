import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String [] firstArr = scanner.nextLine().split("\\s");
        String [] secondArr = scanner.nextLine().split("\\s");

        int minLen = Math.min(firstArr.length,secondArr.length);

        if (firstArr.length < secondArr.length) {
            System.out.println(String.join("",firstArr));
            System.out.println(String.join("",secondArr));
        }
        else if (firstArr.length > secondArr.length) {
            System.out.println(String.join("",secondArr));
            System.out.println(String.join("",firstArr));
        }
        else {
                int result = firstArr[0].compareTo(secondArr[0]);
                if (result >= 1) {
                    System.out.println(String.join("",secondArr));
                    System.out.println(String.join("",firstArr));

                }
                else {
                    System.out.println(String.join("", firstArr));
                    System.out.println(String.join("", secondArr));

                }

        }
    }
}
