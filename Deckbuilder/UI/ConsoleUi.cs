using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Deckbuilder.Interfaces;

namespace Deckbuilder.UI
{
    public class ConsoleUI
    {
        private IStorage Storage { get; set; }
        private ICardSource CardSource { get; set; }

        public void Run(IStorage storage, ICardSource cardSource)
        {
            Storage = storage;
            CardSource = cardSource;
            Console.WriteLine("Welcome! Enter a command");
            Storage.CreateWorkspace();
            while (true)
            {
                var input = Console.ReadLine();
                ProcessCommand(input);
            }
        }

        private void PrintWorkspace()
        {
            Console.WriteLine("Workspace: ");
            var workspace = Storage.GetWorkSpace();
            foreach(var workspaceCard in workspace.WorkspaceCards)
            {
                //var tagString = workspaceCard.Tags.Select(t => t.Name).Aggregate(string.Empty, (current, next) => $"{current}, {next}");
                //Console.WriteLine($"{workspaceCard.Card.Name} : {tagString}");
                Console.WriteLine($"{workspaceCard.Id.Value}");
            }

            Console.WriteLine("Deck: ");
            foreach (var deckCard in workspace.DeckCards)
            {
                Console.WriteLine($"{deckCard.Id}");
            }
        }

        private Logic.Models.WorkspaceCard GetWorkspaceCardByCardName(Logic.Models.Workspace workspace, string cardName)
        {
            var card = workspace.Cards.Find(c => c.Name == cardName); //börjar kännas som man inte slipper allt hämtande ändå, dags att testa nått annat?
            return workspace.WorkspaceCards.Find(wc => wc.CardId == card.Id);
        }

        private void ProcessCommand(string input)
        {
            var splitInput = input.Split(" ");
            var command = splitInput[0];

            var workspace = Storage.GetWorkSpace();

            switch (command)
            {
                case "add":
                    {
                        var payload = splitInput[1];
                        var card = CardSource.GetCard(payload);
                        workspace.AddCard(card);
                    }
                    
                    break;
                case "view":
                    PrintWorkspace();
                    break;
                case "createTag":
                    {
                        var tagName = splitInput[2];
                        workspace.CreateTag(tagName);
                    }
                    break;
                case "addTag":
                    {
                        var cardName = splitInput[1];
                        var tagName = splitInput[2];
                        // hör find logiken hemma i workspace, här eller nånanannstans? adapter kanske?
                        // dessa properties borde kanske inte exponeras alls utåt
                        var tag = workspace.Tags.Find(t => t.Name == tagName);

                        var workspaceCard = GetWorkspaceCardByCardName(workspace, cardName);
                        workspace.AddTag(workspaceCard, tag);
                    }
                    break;
                case "addToDeck":
                    {
                        var cardName = splitInput[1];
                        var workspaceCard = GetWorkspaceCardByCardName(workspace, cardName);
                        workspace.AddToDeck(workspaceCard);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
