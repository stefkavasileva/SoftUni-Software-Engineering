public class Startup
{
    public static void Main()
    {
        /*Room room=new Room("A", 0);
		Room room2=new Room("B", 7);
		Hallway hallway=new Hallway(6);
		hallway.setStart(room);
		hallway.setEnd(room2);
		Room room3=new Room("C", 2);
		Hallway hallway2=new Hallway(8);
		hallway2.setStart(room);
		hallway2.setEnd(room3);
		System.out.println(room);
		System.out.println(room2);
		System.out.println(room3);*/

        Building building = new Building("Java Graph.txt");

        building.print();
    }
}

