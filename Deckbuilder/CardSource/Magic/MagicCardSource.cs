using Deckbuilder.Common;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deckbuilder.CardSource.Magic
{
    public interface ICardFetcher
    {
        Card FetchCard(string cardName);
    }

    public interface ICardStorage
    {
        bool HasCard(string cardName);
        Card GetCard(string cardName);
        Card GetCardById(Id<Card> card);
        void AddCard(Card card);
    }

    public class MagicCardSource : ICardSource
    {
        private ICardFetcher _cardFetcher;
        private ICardStorage _cardStorage;

        public MagicCardSource()
        {
            _cardFetcher = new ScryfallFileCardFetcher("scryfall-default-cards.json");
            _cardStorage = new InMemoryMagicCardStorage();
        }

        public Card GetCard(string cardName)
        {
            if (_cardStorage.HasCard(cardName))
            {
                return _cardStorage.GetCard(cardName);
            }
            else
            {
                var card =_cardFetcher.FetchCard(cardName);
                _cardStorage.AddCard(card);
                return card;
            }
        }

        public Card GetCardById(Id<Card> cardId)
        {
            return _cardStorage.GetCardById(cardId);
        }
    }
}
