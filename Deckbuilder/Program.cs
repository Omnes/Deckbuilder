using System;
using Deckbuilder.CardSource;
using Deckbuilder.CardSource.Magic;
using Deckbuilder.Storage;
using Deckbuilder.UI;

namespace Deckbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new ConsoleUI();
            ui.Run(new InMemoryStorage(), new MagicCardSource());
        }
    }
}
