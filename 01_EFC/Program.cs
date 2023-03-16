﻿using _01_EFC.Services;

var menu = new MenuService();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Skapa en ny ärende/felanmälan");
    Console.WriteLine("2. Visa alla ärende/felanmälanr");
    Console.WriteLine("3. Visa en specifik ärende/felanmälan");
    Console.WriteLine("4. Uppdatera en ärende/felanmälan");
    Console.WriteLine("5. Ta bort en ärende/felanmälan");
    Console.Write("Välj ett av följande alternativ (1-4): ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            await menu.CreateNewContactAsync();
            break;

        case "2":
            Console.Clear();
            await menu.ListAllContactsAsync();
            break;

        case "3":
            Console.Clear();
            await menu.ListSpecificContactAsync();
            break;

        case "4":
            Console.Clear();
            await menu.UpdateSpecificContactAsync();
            break;

        case "5":
            Console.Clear();
            await menu.DeleteSpecificContactAsync();
            break;
    }

    Console.WriteLine("\nTryck på valfri knapp för att fortsätta...");
    Console.ReadKey();
}