using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Deckbuilder.UI
{
    public class ConsoleUI
    {
        private Logic Logic { get; set; }

        public void Run(Logic logic)
        {
            Logic = logic;
            Console.WriteLine("Welcome! Enter a command");
            while (true)
            {
                var input = Console.ReadLine();
                ProcessCommand(input);
            }
        }

        private void PrintWorkspace()
        {
            Console.WriteLine("Workspace: ");
            var workspace = Logic.GetWorkspace();
            foreach(var workspaceCard in workspace.WorkspaceCards)
            {
                var tagString = workspaceCard.Tags.Select(t => t.Name).Aggregate(string.Empty, (current, next) => $"{current}, {next}");
                Console.WriteLine($"{workspaceCard.Card.Name} : {tagString}");
            }
        }

        private void ProcessCommand(string input)
        {
            var splitInput = input.Split(" ");
            var command = splitInput[0];

            switch (command)
            {
                case "add":
                    var payload = splitInput[1];
                    Logic.AddCard(payload);
                    break;
                case "view":
                    PrintWorkspace();
                    break;
                case "addTag":
                    var cardName = splitInput[1];
                    var tag = splitInput[2];
                    Logic.AddTag(cardName, tag);
                    break;

                default:
                    break;
            }
        }
    }
}
