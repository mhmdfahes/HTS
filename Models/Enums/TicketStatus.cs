namespace HTS.Models.Enums
{
    public enum TicketStatus
    {
        Open = 0,         // Ticket is newly created
        InProgress = 1,   // Ticket is being worked on
        OnHold = 2,       // Ticket is temporarily paused
        Resolved = 3,     // Issue has been fixed but not yet closed
        Closed = 4,
        Escalated=5
    }


}