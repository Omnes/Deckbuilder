using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;

namespace Deckbuilder.Storage
{
    public class InMemoryStorage : IStorage
    {
        private Workspace _workspace;

        public void CreateWorkspace()
        {
            _workspace = new Workspace();
        }

        public Workspace GetWorkSpace()
        {
            return _workspace;
        }

        public void SaveWorkspace(Workspace workspace)
        {
            _workspace = workspace;
        }
    }
}
