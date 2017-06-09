using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.CubicArtillery
{
    public class Startup
    {
        public static void Main()
        {
            var maxCapacity = int.Parse(Console.ReadLine());

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            var freeCapacity = maxCapacity;

            var rgx = new Regex("[a-zA-Z]");

            var input = Console.ReadLine();
            while (input != "Bunker Revision")
            {
              var  tokens = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in tokens)
                {
                    if (rgx.IsMatch(item))
                    {
                        bunkers.Enqueue(item);
                    }
                    else
                    {
                        var weaponCapacity = int.Parse(item);

                        var weaponContained = false;
                        while (bunkers.Count > 1)
                        {
                            if (freeCapacity >= weaponCapacity)
                            {
                                weapons.Enqueue(weaponCapacity);
                                freeCapacity -= weaponCapacity;
                                weaponContained = true;
                                break;
                            }

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Peek()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Peek()} -> {string.Join(", ", weapons)}");
                            }

                            bunkers.Dequeue();
                            weapons.Clear();
                            freeCapacity = maxCapacity;
                        }

                        if (!weaponContained && bunkers.Count == 1)
                        {
                            if (maxCapacity >= weaponCapacity)
                            {
                                if (freeCapacity < weaponCapacity)
                                {
                                    while (freeCapacity < weaponCapacity)
                                    {
                                        int removedWeapon = weapons.Dequeue();
                                        freeCapacity += removedWeapon;
                                    }
                                }

                                weapons.Enqueue(weaponCapacity);
                                freeCapacity -= weaponCapacity;
                            }
                        }
                    }

                }

                input = Console.ReadLine();
            }
        }

    }
 }

