using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Deckbuilder.Logic.Interfaces;

namespace Deckbuilder.UI
{
    public class ConsoleUI
    {
        private UiAdapter _uiAdapter;

        public void Run(IStorage storage, ICardSource cardSource)
        {
            storage.CreateWorkspace();
            _uiAdapter = new UiAdapter(cardSource, storage);
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
            foreach(var workspaceCard in _uiAdapter.GetWorkspaceCards())
            {
                //var tagString = workspaceCard.Tags.Select(t => t.Name).Aggregate(string.Empty, (current, next) => $"{current}, {next}");
                //Console.WriteLine($"{workspaceCard.Card.Name} : {tagString}");
                Console.WriteLine($"{workspaceCard.CardName} - {workspaceCard.TagNames}");
            }

            Console.WriteLine("Deck: ");
            foreach (var deckCard in _uiAdapter.GetDeckCards())
            {
                Console.WriteLine($"{deckCard.Id}");
            }
        }

        private void ProcessCommand(string input)
        {
            var splitInput = input.Split(" ");
            var command = splitInput[0];

            switch (command)
            {
                case "add":
                    {
                        var payload = splitInput[1];
                        _uiAdapter.AddCard(payload);
                    }
                    break;
                case "view":
                    PrintWorkspace();
                    break;
                case "createTag":
                    {
                        var tagName = splitInput[1];
                        _uiAdapter.CreateTag(tagName);
                    }
                    break;
                case "addTag":
                    {
                        var cardName = splitInput[1];
                        var tagName = splitInput[2];

                        _uiAdapter.AddTag(cardName, tagName);
                    }
                    break;
                case "addToDeck":
                    {
                        var cardName = splitInput[1];
                        _uiAdapter.AddCardToDeck(cardName);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
