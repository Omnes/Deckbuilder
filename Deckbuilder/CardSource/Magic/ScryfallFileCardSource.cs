using Deckbuilder.Common;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Deckbuilder.CardSource.Magic
{
    public class ScryfallFileCardFetcher : ICardFetcher
    {
        private ScryfallJsonCard[] _rawScryfallCards;
        private List<Card> _parsedCards;

        public ScryfallFileCardFetcher(string jsonFile)
        {
            _parsedCards = new List<Card>();
            var jsonString = File.ReadAllText(jsonFile);
            var jsonCards = JsonConvert.DeserializeObject<ScryfallJsonCard[]>(jsonString);
            _rawScryfallCards = jsonCards;
        }

        public Card FetchCard(string cardName)
        {
            throw new NotImplementedException();
        }

        private Card ToCard(ScryfallJsonCard sjCard)
        {
            throw new NotImplementedException();
        }
    }
}
