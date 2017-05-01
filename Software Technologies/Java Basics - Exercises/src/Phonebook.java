import java.util.HashMap;
import java.util.Scanner;

public class Phonebook {
    public static void main(String [] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();

        HashMap<String,String> phonebook = new HashMap<String,String>();

        while (!inputLine.equals("END")) {
            String[] comandArgs = inputLine.split("\\s");

            if (comandArgs[0].equals("A")) {
                String name = comandArgs[1];
                String phoneNumber = comandArgs[2];

                if (!phonebook.containsKey(name)) {
                    phonebook.put(name, "");
                }

                phonebook.put(name, phoneNumber);

            } else {
                String name = comandArgs[1];

                if (phonebook.containsKey(name)) {
                    System.out.println(name+" -> "+phonebook.get(name));
                } else {
                    System.out.println("Contact "+name+" does not exist.");
                }
            }

            inputLine = scanner.nextLine();
        }
    }
}
