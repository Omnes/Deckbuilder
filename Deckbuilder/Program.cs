using System;
using Deckbuilder.CardSource;
using Deckbuilder.Storage;
using Deckbuilder.UI;

namespace Deckbuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            var storage = new InMemoryStorage();
            storage.CreateWorkspace();

            var logic = new Logic
            {
                CardSource = new ParrotCardSource(),
                Storage = storage
            };

            var ui = new ConsoleUI();
            ui.Run(logic);
        }
    }
}
