using Deckbuilder.Logic.Models;

namespace Deckbuilder.Logic.Interfaces
{
    public interface IStorage
    {
        void CreateWorkspace();

        Workspace GetWorkSpace();

        void SaveWorkspace(Workspace workspace);
    }
}
