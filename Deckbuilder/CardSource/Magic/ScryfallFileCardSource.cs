using Deckbuilder.Common;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Deckbuilder.CardSource.Magic
{
    public class ScryfallFileCardFetcher : ICardFetcher
    {
        private List<ScryfallJsonCard> _rawScryfallCards;

        public ScryfallFileCardFetcher(string jsonFile)
        {
            var jsonString = File.ReadAllText(jsonFile);
            var jsonCards = JsonConvert.DeserializeObject<ScryfallJsonCard[]>(jsonString);
            _rawScryfallCards = jsonCards.ToList();
        }

        public Card FetchCard(string cardName)
        {
            return ToCard(_rawScryfallCards.Find(rsc => rsc.Name == cardName));
        }

        private Card ToCard(ScryfallJsonCard sjCard)
        {
            return new Card(new CardId(sjCard.Id), sjCard.Name);
        }
    }
}
