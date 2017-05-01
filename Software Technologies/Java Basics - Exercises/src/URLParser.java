import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String url = scanner.nextLine();
        int index = url.indexOf("://");

        String protocol ="";
        String server = "";
        String resource = "";

       if(index!=-1){
           protocol = url.substring(0,index);
           url = url.replace(protocol+"://","");
           index = url.indexOf('/');

           if(index!=-1){
               server = url.substring(0,index);
               resource = url.substring(index+1);
           }else{
               server = url;
           }
       }else{
           server = url;
       }

        System.out.println("[protocol] = " + "\"" + protocol.trim() + "\"");
        System.out.println("[server] = "+ "\"" + server.trim() + "\"");
        System.out.println("[resource] = "+ "\"" +resource.trim() + "\"" );

    }
}
