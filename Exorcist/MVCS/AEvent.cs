using System;

namespace Exorcist.MVCS
{
    public abstract class AEvent : Object
    {
    }
    
    public abstract class AModelEvent : AEvent
    {
    }

    public abstract class AViewEvent : AEvent
    {
    }
    
    public abstract class AServiceEvent : AEvent
    {
    }
}