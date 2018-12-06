using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Models;

namespace Deckbuilder.Interfaces
{
    public interface IStorage
    {
        void CreateWorkspace();

        Workspace GetWorkSpace();

        void SaveWorkspace();
    }
}
