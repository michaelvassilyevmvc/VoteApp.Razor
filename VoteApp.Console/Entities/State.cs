using System.ComponentModel;

namespace VoteApp.Console.Entities
{
    public enum State
    {
        [Description("Архив")]
        Archive = 0,
        [Description("Действующий")]
        Active = 1,
        [Description("Удален")]
        Delete = 2
    }
}
