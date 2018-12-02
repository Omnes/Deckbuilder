using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Models;

namespace Deckbuilder.Interfaces
{
    public interface IStorage
    {
        void CreateWorkspace();

        void AddWorkspaceCard(WorkspaceCard workspaceCard);

        void AddTag(WorkspaceCard workspaceCard, Tag tag);

        Workspace GetWorkSpace();
    }
}
