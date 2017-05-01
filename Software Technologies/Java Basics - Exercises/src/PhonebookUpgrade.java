import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade {
    public static void main(String [] args)
    {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();

        TreeMap<String,String> phonebook = new TreeMap<String,String>();

        while (!inputLine.equals("END")) {
            String[] comandArgs = inputLine.split("\\s");

            if (comandArgs[0].equals("A")) {
                String name = comandArgs[1];
                String phoneNumber = comandArgs[2];

                if (!phonebook.containsKey(name)) {
                    phonebook.put(name, "");
                }

                phonebook.put(name, phoneNumber);

            }
            else if (comandArgs[0].equals("S")) {
                String name = comandArgs[1];

                if (phonebook.containsKey(name)) {
                    System.out.println(name+" -> "+phonebook.get(name));
                }
                else {
                    System.out.println("Contact "+name+" does not exist.");
                }
            }
            else
            {
                for (String key : phonebook.keySet())
                {
                    System.out.println(key+" -> "+phonebook.get(key));
                }
            }

            inputLine = scanner.nextLine();
        }
    }
}
