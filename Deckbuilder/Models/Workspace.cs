using System;
using System.Collections.Generic;
using System.Text;

namespace Deckbuilder.Models
{
    public class Workspace
    {
        public Deck Deck { get; set; }
        public List<WorkspaceCard> WorkspaceCards { get; set; }

        public Workspace()
        {
            Deck = new Deck();
            WorkspaceCards = new List<WorkspaceCard>();
        }
    }
}
