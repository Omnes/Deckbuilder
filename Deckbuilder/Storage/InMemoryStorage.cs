using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Interfaces;
using Deckbuilder.Models;

namespace Deckbuilder.Storage
{
    public class InMemoryStorage : IStorage
    {
        private Workspace workspace {get; set;}

        public void AddTag(WorkspaceCard workspaceCard, Tag tag)
        {
            workspaceCard.Tags.Add(tag);
        }

        public void AddWorkspaceCard(WorkspaceCard workspaceCard)
        {
            workspace.WorkspaceCards.Add(workspaceCard);
        }

        public void CreateWorkspace()
        {
            workspace = new Workspace();
        }

        public Workspace GetWorkSpace()
        {
            return workspace;
        }
    }
}
