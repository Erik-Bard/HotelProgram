using System;

namespace HotelProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //----- Declaration of variables -------
            int MainMenu = 0;
            int BookHotelSelected = 0;
            int minibar = 0;
            int CostOfStay;
            int LunchDinner = 0;
            int NightsToBill = 0;
            int FoodBill = 0;
            int ReturnMenu = 0;
            bool Continiue = true;
            int DrinkSelect = 0;
            int CourseSelect = 0;
            int SelectTrip = 0;
            //--------------------------------------

            while (Continiue)
            {

            // ---- Welcome ----
            Console.WriteLine(" -------------------------------");
            Console.WriteLine("   Welcome to Hotell Papagoya!");
            Console.WriteLine(" -------------------------------");

            //------ start menu -------
                Console.WriteLine("This is a List of what we Offer: ");
                Console.WriteLine("1: Book Hotel room");
                Console.WriteLine("2: Go to Bar");
                Console.WriteLine("3: Go to Golf Course");
                Console.WriteLine("4: Head to swimmingpool");
                Console.WriteLine("5: Book a guided trip");
                Console.WriteLine("6: Leave Hotel");
                bool IsMenuValid = int.TryParse(Console.ReadLine(), out MainMenu);
                if (IsMenuValid)
                {
                    // NOTE : Start Calulate money added to Bill. 

                    switch (MainMenu)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Please select which room you would like:");
                            Console.WriteLine("1: Standard room, 2 beds / 1 Bathroom : £250 /night");
                            Console.WriteLine("2: Standard-Deluxe room, 2 King-sized beds / 2 Bathrooms : £350 /night");
                            Console.WriteLine("3: Deluxe+ room, 4 King-sized beds / 4 Bathrooms : £450 /night");
                            Console.WriteLine("4: Penthouse floor room, 4 Kong-sized beds / 4 Bathrooms with Jaccuzzi : £700 /night");
                            bool roomselected = int.TryParse(Console.ReadLine(), out BookHotelSelected);
                            switch (BookHotelSelected)
                            {
                                case 1:
                                    Console.WriteLine("Standard room selected.");
                                    Console.WriteLine("How many nights do you wish to stay?");
                                    bool nights = int.TryParse(Console.ReadLine(), out NightsToBill);
                                    CostOfStay = NightsToBill * 250;
                                    Console.WriteLine("£" + CostOfStay);
                                    Console.WriteLine("Will you use the minibar on your stay? 1: Yes, 2: No.");
                                    bool IfMinibar = int.TryParse(Console.ReadLine(), out minibar);
                                    if (minibar == 1)
                                    {
                                        Console.WriteLine("Minibar will add £50 to your stay.");
                                        CostOfStay += 50;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (minibar == 2)
                                    {
                                        Console.WriteLine("No minibar will be used, please press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("Breakfast is included, do you wish to include Lunch + Dinner every night? 1: Yes, 2: No.");
                                    bool food = int.TryParse(Console.ReadLine(), out LunchDinner);
                                    if (LunchDinner == 1)
                                    {
                                        Console.WriteLine("This will add £5 per day");
                                        // NOTE : Calculate ammount of money added per day hotelroom booked. 
                                        FoodBill = NightsToBill * 5;
                                        CostOfStay += FoodBill;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (LunchDinner == 2)
                                    {
                                        Console.WriteLine("Only breakfast it is. Press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Your Bill for this stay is: £" + CostOfStay);
                                    Console.WriteLine("Enjoy your stay here at Hotel Papagoya!");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if(ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if(ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                break;
                                case 2:
                                    Console.WriteLine("Standard-Deluxe room selected.");
                                    Console.WriteLine("How many nights do you wish to stay?");
                                    bool nights2 = int.TryParse(Console.ReadLine(), out NightsToBill);
                                    CostOfStay = NightsToBill * 350;
                                    Console.WriteLine("£" + CostOfStay);
                                    Console.WriteLine("Will you use the minibar on your stay? 1: Yes, 2: No.");
                                    bool IfMinibar2 = int.TryParse(Console.ReadLine(), out minibar);
                                    if (minibar == 1)
                                    {
                                        Console.WriteLine("Minibar will add £50 to your stay.");
                                        CostOfStay += 50;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (minibar == 2)
                                    {
                                        Console.WriteLine("No minibar will be used, please press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("Breakfast is included, do you wish to include Lunch + Dinner every night? 1: Yes, 2: No.");
                                    bool food2 = int.TryParse(Console.ReadLine(), out LunchDinner);
                                    if (LunchDinner == 1)
                                    {
                                        Console.WriteLine("This will add £5 per day");
                                        // NOTE : Calculate ammount of money added per day hotelroom booked. 
                                        FoodBill = NightsToBill * 5;
                                        CostOfStay += FoodBill;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (LunchDinner == 2)
                                    {
                                        Console.WriteLine("Only breakfast it is. Press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Your Bill for this stay is: £" + CostOfStay);
                                    Console.WriteLine("Enjoy your stay here at Hotel Papagoya!");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn2 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Standard-Deluxe room selected.");
                                    Console.WriteLine("How many nights do you wish to stay?");
                                    bool nights3 = int.TryParse(Console.ReadLine(), out NightsToBill);
                                    CostOfStay = NightsToBill * 450;
                                    Console.WriteLine("£" + CostOfStay);
                                    Console.WriteLine("Will you use the minibar on your stay? 1: Yes, 2: No.");
                                    bool IfMinibar3 = int.TryParse(Console.ReadLine(), out minibar);
                                    if (minibar == 1)
                                    {
                                        Console.WriteLine("Minibar will add £50 to your stay.");
                                        CostOfStay += 50;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (minibar == 2)
                                    {
                                        Console.WriteLine("No minibar will be used, please press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("Breakfast is included, do you wish to include Lunch + Dinner every night? 1: Yes, 2: No.");
                                    bool food3 = int.TryParse(Console.ReadLine(), out LunchDinner);
                                    if (LunchDinner == 1)
                                    {
                                        Console.WriteLine("This will add £5 per day");
                                        // NOTE : Calculate ammount of money added per day hotelroom booked. 
                                        FoodBill = NightsToBill * 5;
                                        CostOfStay += FoodBill;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (LunchDinner == 2)
                                    {
                                        Console.WriteLine("Only breakfast it is. Press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Your Bill for this stay is: £" + CostOfStay);
                                    Console.WriteLine("Enjoy your stay here at Hotel Papagoya!");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn3 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Standard-Deluxe room selected.");
                                    Console.WriteLine("How many nights do you wish to stay?");
                                    bool nights4 = int.TryParse(Console.ReadLine(), out NightsToBill);
                                    CostOfStay = NightsToBill * 700;
                                    Console.WriteLine("£" + CostOfStay);
                                    Console.WriteLine("Will you use the minibar on your stay? 1: Yes, 2: No.");
                                    bool IfMinibar4 = int.TryParse(Console.ReadLine(), out minibar);
                                    if (minibar == 1)
                                    {
                                        Console.WriteLine("Minibar will add £50 to your stay.");
                                        CostOfStay += 50;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (minibar == 2)
                                    {
                                        Console.WriteLine("No minibar will be used, please press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("Breakfast is included, do you wish to include Lunch + Dinner every night? 1: Yes, 2: No.");
                                    bool food4 = int.TryParse(Console.ReadLine(), out LunchDinner);
                                    if (LunchDinner == 1)
                                    {
                                        Console.WriteLine("This will add £5 per day");
                                        // NOTE : Calculate ammount of money added per day hotelroom booked. 
                                        FoodBill = NightsToBill * 5;
                                        CostOfStay += FoodBill;
                                        Console.WriteLine("£" + CostOfStay);
                                    }
                                    if (LunchDinner == 2)
                                    {
                                        Console.WriteLine("Only breakfast it is. Press any key to continiue.");
                                        Console.ReadKey();
                                    }
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Your Bill for this stay is: £" + CostOfStay);
                                    Console.WriteLine("Enjoy your stay here at Hotel Papagoya!");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn4 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("You are at the Bar.");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("Drinks Menu:");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("1: Martini");
                            Console.WriteLine("2: Manhattan");
                            Console.WriteLine("3: Sidecar");
                            Console.WriteLine("4: Screwdriver");
                            Console.WriteLine("5: Margarita");
                            bool IsDrinkSelected = int.TryParse(Console.ReadLine(), out DrinkSelect);
                            switch (DrinkSelect)
                            {
                                case 1:
                                    Console.WriteLine("A Martini");
                                    Console.WriteLine("Made with Gin and Vermouth. Garnished with an olive or/and lemon twist.");
                                    Console.WriteLine("To pay: £8");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Press any key to continiue..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("A Manhattan");
                                    Console.WriteLine("Made with Whiskey, vermouth, angostura(bitter).");
                                    Console.WriteLine("To pay: £6.50");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Press any key to continiue..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("A Sidecar");
                                    Console.WriteLine("Made with Cognac, lemon juice and Brandy Crusta.");
                                    Console.WriteLine("To pay: £1400");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Press any key to continiue..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.WriteLine("A Screwdriver");
                                    Console.WriteLine("Made with Vodka and orange juice.");
                                    Console.WriteLine("To pay: £1.50");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Press any key to continiue..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 5:
                                    Console.WriteLine("A Margarita");
                                    Console.WriteLine("Made with Tequila, triple sec, ice and lime juice.");
                                    Console.WriteLine("To pay: £10");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Press any key to continiue..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("This is the Hotel's Golf Course.");
                            Console.WriteLine("Please select your prefered Course:");
                            Console.WriteLine("1: Links Course");
                            Console.WriteLine("2: Parkland Course");
                            Console.WriteLine("3: Desert Course");
                            Console.WriteLine("4: Sand Course");
                            Console.WriteLine("5: Snow/Ice Course");
                            bool IsCourseSelected = int.TryParse(Console.ReadLine(), out CourseSelect);
                            switch(CourseSelect)
                            {
                                case 1:
                                    Console.WriteLine("Link Course Features: ");
                                    Console.WriteLine("Natural Hazards,  the golf courses are created around natural" +
                                        "\n hazards of a coast, although bunkers are deepened to prevent sand blowing away.");
                                    Console.WriteLine("Terrain is refered to as Rolling.");
                                    Console.WriteLine("Usually very windy all year 'round! Bring your windstoppers!");
                                    Console.WriteLine("Feel free to use the Hotel's gear, just put it back when you are done.");
                                    Console.WriteLine("Total to pay: £120");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Parkland Course Features: ");
                                    Console.WriteLine("Parkland golf courses appeared as a result of moving links courses more inland. " +
                                        "\n Characterised by design elements, natural settings and narrower fairways enclosed by trees and lush greeneries, " +
                                        "\n many PGA tours take place on these terrain types.");
                                    Console.WriteLine("- Natural clay underlay");
                                    Console.WriteLine("- There may be potentially less roll, especially in bad weather conditions. ");
                                    Console.WriteLine("Feel free to use the Hotel's gear, just put it back when you are done.");
                                    Console.WriteLine("Total to pay: £150");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn1 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Desert Course Features: ");
                                    Console.WriteLine("Playing in the desert is fantastic, though, as you’ll be surrounded by beautiful plants and animals while you play," +
                                        "\n not to mention the warm weather. Just don’t forget your sunglasses or sun-cream!");
                                    Console.WriteLine("Feel free to use the Hotel's gear, just put it back when you are done.");
                                    Console.WriteLine("Total to pay: £160");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn2 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Sand Course Features: ");
                                    Console.WriteLine("Through trial and error, workers created optimum green surfaces (known as ‘browns’)" +
                                        "\n by mixing the sand and oil to create golf terrain that is slower but truer. For fully sanded courses," +
                                        "\n golfers could even be permitted to bring Astroturf with them to avoid the feeling of continuous bunker shots." +
                                        "\n They were taken over by emerging green golf courses shortly afterwards, though they are an interesting alternative to standard types of golf courses.");
                                    Console.WriteLine("Feel free to use the Hotel's gear, just put it back when you are done.");
                                    Console.WriteLine("Total to pay: £190");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn3 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Snow/Ice Course Features: ");
                                    Console.WriteLine("A less popular, but interesting way to play golf is on a fully iced or" +
                                        "\n snow golf course – you don’t need to worry about the right club for each type of grass here!");
                                    Console.WriteLine("- Snow blindness and movement constrictions due to thermal clothing.");
                                    Console.WriteLine("- Rough surfaces due to a layer of snow lying over the course – graphite clubs are discouraged as they may shatter!");
                                    Console.WriteLine("- The danger of seal dens and crevasses.");
                                    Console.WriteLine("Feel free to use the Hotel's gear, just put it back when you are done.");
                                    Console.WriteLine("Total to pay: £230");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturn4 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("What a beautiful pool! So many people!");
                            Console.WriteLine("*You look for empty seats*");
                            Console.WriteLine("Is there any empty deck-chairs?");
                            Console.WriteLine("There are a total of 50 chairs with parasols");
                            Random rnd = new Random();
                            int dice = rnd.Next(0, 50);
                            Console.WriteLine("How many empty seats are there?");
                            Console.WriteLine("There are: " + dice + " seats available!");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                            bool MenuReturn5 = int.TryParse(Console.ReadLine(), out ReturnMenu);
                            if (ReturnMenu == 1)
                            {
                                Console.Clear();
                            }
                            if (ReturnMenu == 2)
                            {
                                Continiue = false;
                            }
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Menu for Guided trips:");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("1: Experience the Amalfi Coast");
                            Console.WriteLine("2: Rome to Amalfi");
                            Console.WriteLine("3: The best of Spain");
                            Console.WriteLine("4: Explore Machu Picchu");
                            Console.WriteLine("5: Can't Decide? Roll the Dice :)");
                            bool SelectedTripCheck = int.TryParse(Console.ReadLine(), out SelectTrip);
                            switch(SelectTrip)
                            {
                                case 1:
                                    Console.WriteLine("Trip to Amalfi Coast span over 8 days.");
                                    Console.WriteLine("Total cost of: £120");
                                    break;
                                case 2:
                                    Console.WriteLine("Trip between ROme and Amalfi spans over 8 days.");
                                    Console.WriteLine("Total cost of: £400");
                                    break;
                                case 3:
                                    Console.WriteLine("Trip to the best parts of Spain spans over 12 days.");
                                    Console.WriteLine("Total cost of: £300");
                                    break;
                                case 4:
                                    Console.WriteLine("Trip to Machu Picchu spans over 11 days.");
                                    Console.WriteLine("Total cost of: £200");
                                    break;
                                case 5:
                                    Random rng = new Random();
                                    int tripdice = rng.Next(1, 4);
                                    Console.WriteLine("Rolling the Trip-dice!");
                                    Console.WriteLine("It chose trip number: " + tripdice + " !");
                                    Console.WriteLine("Enjoy your trip!");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Do you wish to return to Main Menu? 1: Yes, 2: No, Exit Program.");
                                    bool MenuReturnblah = int.TryParse(Console.ReadLine(), out ReturnMenu);
                                    if (ReturnMenu == 1)
                                    {
                                        Console.Clear();
                                    }
                                    if (ReturnMenu == 2)
                                    {
                                        Continiue = false;
                                    }
                                    break;
                            }
                            break;
                        case 6:
                            Console.WriteLine("Goodbye! We hope to see you Again Soon!");
                            Continiue = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Fel. Var god välj en godkänd siffra.");
                }
            }
        }
    }
}
