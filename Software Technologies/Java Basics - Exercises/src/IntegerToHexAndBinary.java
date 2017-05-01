import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int decimalNum = scanner.nextInt();

        System.out.println(Integer.toHexString(decimalNum).toUpperCase());
        System.out.println(Integer.toBinaryString(decimalNum));
    }
}
