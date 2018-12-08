using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;

namespace Deckbuilder.Storage
{
    public class InMemoryStorage : IStorage
    {
        private Workspace workspace {get; set;}

        public void CreateWorkspace()
        {
            workspace = new Workspace();
        }

        public Workspace GetWorkSpace()
        {
            return workspace;
        }

        public void SaveWorkspace()
        {
            
        }
    }
}
