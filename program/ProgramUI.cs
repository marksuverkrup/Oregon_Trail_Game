using program;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oregon_Trail
{
    public class ProgramUI
    {
        public void Run()
        {
            OregonTrailStartMenu();
        }
        public void OregonTrailStartMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Oregon Trail.\n ");

                Console.WriteLine(
                    "Enter the number of the option you would like to select:\n" +
                    "1. Enter the Oregon Trail\n" +
                    "2. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        OregonTrail();
                        break;
                    case "2":
                        isRunning = false;
                        break;
                    default:
                        OregonTrail();
                        break;
                }
            }
        }
        public void OregonTrail()
        {
            Console.Clear();
            int turnCounter = 0;
            Console.WriteLine("You are now entering the Oregon Trail.\n" +
                "The year is 1811, and you and your family are attempting to traverse the trail from Missouri to Oregon\n" +
                "With you in the wagon is you brother, sister, Ma, Pa, and two oxen pulling the wagon named Larry and Martin\n" +
                "You will encounter many challenges, and have to make tough decisions of how to make it through to the great riches of Oregon. \n");

            PressAnyKey();

            Wagon_Contents wagon_Contents = new Wagon_Contents(true, true, true, true, true, true, 50);
            string commands = "Deer,GoodRiver,Deer,BadIndians,Deer,GoodRain,Bison,BadRiver,GoodSettlement,Bison,GoodIndians,Deer,Deer,GoodForest,BigStorm,WagonWheelBreak,BadForest,BadSettlement,GoodRiver,Deer,BadMountain,GoodForest,Bear,GoodMountain,Victory";
            string[] commandArray = commands.Split(',');

            foreach (string item in commandArray)
            {
                if (wagon_Contents.Supplies >= 0)
                {
                    Console.WriteLine("\nSupplies: " + wagon_Contents.Supplies);
                    Console.WriteLine("Brother is alive: " + wagon_Contents.Brother);
                    Console.WriteLine("Sister is alive: " + wagon_Contents.Sister);
                    Console.WriteLine("Ma is alive: " + wagon_Contents.Ma);
                    Console.WriteLine("Pa is alive: " + wagon_Contents.Pa);
                    Console.WriteLine("Ox Larry is alive: " + wagon_Contents.OxLarry);
                    Console.WriteLine("Ox Martin is alive: " + wagon_Contents.OxMartin);
                    turnCounter = turnCounter + 1;
                    PressAnyKey();

                    if (item == "Deer")
                    {
                        Console.Clear();

                        Console.WriteLine("Came across a Deer, Time to Hunt!");
                        Console.ReadKey();
                        bool hunt = HuntTimeDeer();
                        if (hunt == true)
                        {
                            Console.WriteLine("You have successfully hunted a deer, and gained 10 supplies.");
                            wagon_Contents.Supplies += 10;
                        }
                        else
                        {
                            Console.WriteLine("You were not able to hunt the deer.");
                        }
                        PressAnyKey();
                    }
                    else if (item == "Bison")
                    {
                        Console.Clear();

                        Console.WriteLine("Came across a Bison, Time to Hunt!");
                        Console.ReadKey();
                        bool hunt = HuntTimeBison();
                        if (hunt == true)
                        {
                            Console.WriteLine("You have successfully hunted a bison, and gained 20 supplies.");
                            wagon_Contents.Supplies += 20;
                        }
                        else
                        {
                            Console.WriteLine("You were not able to hunt the bison.");
                        }
                        PressAnyKey();
                    }
                    else if (item == "Bear")
                    {
                        Console.Clear();

                        Console.WriteLine("Came across a Bear, Time to Hunt!");
                        Console.ReadKey();
                        bool hunt = HuntTimeBear();
                        if (hunt == true)
                        {
                            Console.WriteLine("You have successfully hunted a bear, and gained 50 supplies.");
                            wagon_Contents.Supplies += 50;
                        }
                        else
                        {
                            Console.WriteLine("You were not able to hunt the bear.");
                        }
                        PressAnyKey();
                    }
                    else if (item == "GoodRiver")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross a river. \n" +
                    "Enter the number of the option you would like to select: \n" +
                    "1. Attempt to go through the river.\n" +
                    "2. Wait for conditions to improve.\n");

                        string userInputRiver = Console.ReadLine();

                        switch (userInputRiver)
                        {
                            case "1":
                                Console.WriteLine("The trail has been kind to you, you have made it through the river."); ;
                                break;
                            case "2":
                                Console.WriteLine("You waited and lost 15 supplies, but were able to make it though the river unscathed");
                                wagon_Contents.Supplies -= 15;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to wait.");
                                Console.WriteLine("You waited and lost 15 supplies, but were able to make it though the river unscathed");
                                wagon_Contents.Supplies -= 15;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "BadRiver")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross a river.\n"+
                    "Enter the number of the option you would like to select:\n" +
                    "1. Attempt to go through the river.\n" +
                    "2. Wait for conditions to improve.\n");

                        string userInputRiver = Console.ReadLine();

                        switch (userInputRiver)
                        {
                            case "1":
                                Console.WriteLine("The trail has been unkind to you, wagon broke down in the river and Ox Martin died.");
                                wagon_Contents.OxMartin = false;
                                break;
                            case "2":
                                Console.WriteLine("You waited and lost 15 supplies, but were able to make it though the river unscathed");
                                wagon_Contents.Supplies -= 15;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to wait.");
                                Console.WriteLine("You waited and lost 15 supplies, but were able to make it though the river unscathed");
                                wagon_Contents.Supplies -= 15;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "GoodIndians")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross a tribe of Indians, they may have supplies,but they may not be friendly.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go around the Indians and try not to be seen.\n" +
                    "2. Ask the Indians for help.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to avoid to the Indians, but the extra time cost you 10 supplies");
                                wagon_Contents.Supplies -= 10;
                                break;
                            case "2":
                                Console.WriteLine("You have made friends with the Indians, and have been gifted 25 supplies");
                                wagon_Contents.Supplies += 25;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to avoid.");
                                Console.WriteLine("You were able to avoid to the Indians, but the extra time cost you 10 supplies");
                                wagon_Contents.Supplies -= 10;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "BadIndians")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross a tribe of Indians, they may have supplies,but they may not be friendly.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go around the Indians and try not to be seen.\n" +
                    "2. Ask the Indians for help.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to avoid to the Indians, but the extra time cost you 10 supplies");
                                wagon_Contents.Supplies -= 10;
                                break;
                            case "2":
                                Console.WriteLine("The Indians did not take kindly to your arrival, and your sister was killed by an arrow");
                                wagon_Contents.Sister = false;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to encounter the Indians.");
                                Console.WriteLine("The Indians did not take kindly to your arrival, and your sister was killed by an arrow");
                                wagon_Contents.Sister = false;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "GoodRain")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come into rain, and travel will be more difficult.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Wait out the rain in shelter.\n" +
                    "2. Try your best to get through it.\n.");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to avoid to the rain, but the extra time cost you 20 supplies.");
                                wagon_Contents.Supplies -= 20;
                                break;
                            case "2":
                                Console.WriteLine("You were barely able to make it through, but have not wasted any supplies.");
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to wait.");
                                Console.WriteLine("You were able to avoid to the rain, but the extra time cost you 20 supplies.");
                                wagon_Contents.Supplies -= 20;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "BigStorm")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come into a big storm, it is very cold.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Wait out the storm in shelter.\n" +
                    "2. Try your best to get through it.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to avoid to the storm, but the extra time cost you 15 supplies.");
                                wagon_Contents.Supplies -= 15;
                                break;
                            case "2":
                                Console.WriteLine("You were able to make it through, but Ma was not able to survive the cold, and Ma died after contracting colera.");
                                wagon_Contents.Ma = false;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to wait.");
                                Console.WriteLine("You were able to make it through, but Ma was not able to survive the cold, and Ma died after contracting colera.");
                                wagon_Contents.Ma = false;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "GoodSettlement")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross a town, with settlers and suplies, but beware they may not appreciate rough prospectors.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go into the town and attempt to barter for needed supplies.\n" +
                    "2. Go out of your way to avoid the valley town.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to barter with the townspeople, generating 20 supplies for the journey ahead.");
                                wagon_Contents.Supplies += 20;
                                break;
                            case "2":
                                Console.WriteLine("You were able to avoid going into the town, but the extra time cost you 10 supplies.");
                                wagon_Contents.Supplies -= 10;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to avoid the town.");
                                Console.WriteLine("You were able to avoid going into the town, but the extra time cost you 10 supplies.");
                                wagon_Contents.Supplies -= 10;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "BadSettlement")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross a town, with settlers and suplies, but beware they may not appreciate rough prospectors.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go into the town and attempt to barter for needed supplies.\n" +
                    "2. Go out of your way to avoid the mountain town.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to barter with the townspeople, generating 20 supplies for the journey ahead.");
                                wagon_Contents.Supplies += 20;
                                break;
                            case "2":
                                Console.WriteLine("You were able to avoid going into the town, but the extra time cost you 10 supplies.");
                                wagon_Contents.Supplies -= 10;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to avoid friendly mountain town.");
                                Console.WriteLine("You were able to avoid going into the town, but the extra time cost you 10 supplies.");
                                wagon_Contents.Supplies -= 10;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "GoodMountain")
                    {
                        Console.Clear();

                        Console.WriteLine(
                            "You have come across the mountains. You are getting close to Oregon! The mountains can be treacherous though!\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go over the Mountain trail. \n" +
                    "2. Try to find a pass through mountains.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to make it through the mountain and save time along the way.");
                                break;
                            case "2":
                                Console.WriteLine("You were able to find a mountain pass but, this cost valuable time resulting in a loss of 10 supplies.");
                                wagon_Contents.Supplies -= 10;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to find a pass.");
                                Console.WriteLine("You were able to find a mountain pass but, this cost valuable time resulting in a loss of 10 supplies.");
                                wagon_Contents.Supplies -= 10;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "BadMountain")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come accross another mountain. This mountain looks more treacherous the last and there are three paths.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go over the mountain trail.\n" +
                    "2. Go on the trail leading right of the mountain. \n" +
                    "3. Go on the trail leading left of the mountain.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You hit a cliff at the top of the mountain during a blizzard. You must turn back in the cold. Your brother falls off the cliff and you lose most of your supplies.");
                                wagon_Contents.Supplies -= 50;
                                wagon_Contents.Brother = false;
                                break;
                            case "2":
                                Console.WriteLine("You hit a dead end and must turn back. Your error in judgement means that 35 supplies are lost.");
                                wagon_Contents.Supplies -= 35;
                                break;
                            case "3":
                                Console.WriteLine("You were able to pass through the mountain range unharmed. Only 10 supplies were used through the pass.");
                                wagon_Contents.Supplies -= 10;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to go over.");
                                Console.WriteLine("You hit a cliff at the top of the mountain during a blizzard. You must turn back in the cold. Your brother falls off the cliff and you lose most of your supplies.");
                                wagon_Contents.Supplies -= 50;
                                wagon_Contents.Brother = false;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "GoodForest")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come across a forest. There look to be a path through the forest and one around the forest.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go through the trail through the middle of the forest.\n" +
                    "2. Go on the trail around the forest. \n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("The forest was very dense and the trail tough. It takes a while to navigate but, you make it out of the other side. You lose 20 supplies in the forest.");
                                wagon_Contents.Supplies -= 20;
                                break;
                            case "2":
                                Console.WriteLine("The trail around the forest was longer than expected. You use 30 supplies going around.");
                                wagon_Contents.Supplies -= 30;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been forced to go around.");
                                Console.WriteLine("The trail around the forest was longer than expected. You use 30 supplies going around.");
                                wagon_Contents.Supplies -= 30;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "BadForest")
                    {
                        Console.Clear();

                        Console.WriteLine(
                    "You have come across a forest. There look to be two paths through the forest.\n" +
                    "Enter the number of the option you would like to select:\n" +
                    "1. Go through the trail to the left of the forest.\n" +
                    "2. Go through the trail to the right of the forest. \n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("Your wagon was attacked by a panther. You were able to escape but, your ox Larry died. Also, you lost 30 supplies in the attack.");
                                wagon_Contents.Supplies -= 30;
                                wagon_Contents.OxLarry = false;
                                if (wagon_Contents.OxMartin == false)
                                {
                                    wagon_Contents.Supplies -= 100;
                                    Console.WriteLine("Both your Oxen have died. You have lost 100 supplies waiting for rescue in the wilderness.");
                                }
                                break;
                            case "2":
                                Console.WriteLine("The forest was very dense and the trail tough. It takes a while to navigate but, you make it out of the other side. You lose 20 supplies in the forest.");
                                wagon_Contents.Supplies -= 20;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, and have been attacked by a Panther.");
                                Console.WriteLine("Your wagon was attacked by a panther. You were able to escape but, your ox Larry died. Also, you lost 30 supplies in the attack.");
                                wagon_Contents.Supplies -= 30;
                                wagon_Contents.OxLarry = false;
                                if (wagon_Contents.OxMartin == false)
                                {
                                    wagon_Contents.Supplies -= 100;
                                    Console.WriteLine("Both your Oxen have died. You have lost 100 supplies waiting for rescue in the wilderness.");
                                }
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "WagonWheelBreak")
                    {
                        Console.Clear();

                        Console.WriteLine(
                            "You hit a rock and your wagon wheel broke!\n" +
                            "Enter the number of the option you would like to select:\n" +
                            "1. Fix your wagon wheel with supplies.\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You were able to fix the wheel with 15 supplies.");
                                wagon_Contents.Supplies -= 15;
                                break;
                            default:
                                Console.WriteLine("You have entered an invalid input, but the wagon still needs fixin.");
                                Console.WriteLine("You were able to fix the wheel with 15 supplies.");
                                wagon_Contents.Supplies -= 15;
                                break;
                        }
                        PressAnyKey();
                    }
                    else if (item == "Victory")
                    {
                        int daysSurvived = turnCounter * 7;
                        Console.WriteLine(
                            "\nYou have finished your journey on the Oregon and arrived at Oregon Ciy!\n" +
                            "The journey took you " + daysSurvived + " days to reach Oregon!\n" +
                            "Enter the number of the option you would like to select:\n" +
                            "1. Go back to the Main Menu\n");

                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                OregonTrailStartMenu();
                                break;
                            default:
                                OregonTrailStartMenu();
                                break;
                        }
                    }
                }
                else
                {
                    int daysSurvived = turnCounter * 7;
                    Console.WriteLine("\nYou have run out of supplies and everyone has died. \n" +
                        "You survived for " + daysSurvived + " days on the Oregon Trail.");
                    PressAnyKey();
                    OregonTrailStartMenu();
                    
                }
            }
        }
        public void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue on your journey.");
            Console.ReadKey();
        }
        public bool HuntTimeDeer()
        {
            Console.WriteLine("Please enter 'Pow' in 5 seconds.");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string huntInput = Console.ReadLine();
            stopWatch.Stop();
            long huntTime = stopWatch.ElapsedMilliseconds;
            if (huntInput == "Pow" && huntTime <= 5000)
            {
                return true;
            }
            else
            {   
                return false;
            }
        }
        public bool HuntTimeBison()
        {
            Console.WriteLine("Please enter 'snap' in 5 seconds.");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string huntInput = Console.ReadLine();
            stopWatch.Stop();
            long huntTime = stopWatch.ElapsedMilliseconds;
            if (huntInput == "snap" && huntTime <= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HuntTimeBear()
        {
            Console.WriteLine("Please enter 'BaNg' in 5 seconds.");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string huntInput = Console.ReadLine();
            stopWatch.Stop();
            long huntTime = stopWatch.ElapsedMilliseconds;
            if (huntInput == "BaNg" && huntTime <= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
