using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard;
using Spectre;
using Spectre.Console;

internal class Menu
{
    internal static void MainMenu()
    {
        bool exit = false;

        while (!exit)
        {
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("What do you want to do?: ")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .AddChoices(new[]
                {
                    "Exit", "Manage Stacks", "Manage Flashcards",
                    "Study", "View study session data"
                }));


            switch (menu)
            {
                case "Exit":
                    exit = true;
                    AnsiConsole.MarkupLine("[green3]Goodbye![/]");
                    break;

                case "Manage Stacks":
                    break;

                case "Manage Flashcards":
                    break;

                case "Study":
                    break;

                case "View study session data":
                    break;
            }
        }
    }


    internal static void ManageStacks()
    {
        var menu = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("What do you want to do with the stacks?: ")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
            .AddChoices(new[]
            {
                ""
            }));
    }
}
