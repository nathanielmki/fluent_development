namespace App1.Services.Ink.UndoRedo
{
    public interface IUndoRedoOperation
    {
        void ExecuteUndo();

        void ExecuteRedo();
    }
}
