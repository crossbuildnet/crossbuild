using Crossbuild.Core.Abstract;

namespace Crossbuild.Core.Interfaces;

public interface IClientEvents
{
    event EventHandler<string> Error;
    event EventHandler<string> Warn;
    event EventHandler<string> Debug;
    event EventHandler Ready;
    event EventHandler<Message> Message;
}