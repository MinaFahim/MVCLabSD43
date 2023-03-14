namespace LabD_02.Models.Domain;

    public class Ticket
    {
        public Guid Id { get; set; }    
        public DateTime CreatedDate { get; set; }
        public bool Isclosed { get; set; }
        public string Description { get; set; }
    public Severity severity { get; set; }
    public Ticket()
    {

    }
    public Ticket( Guid id,DateTime date,bool isclosed,string desc, Severity serv)
    {
       Id= id;
        CreatedDate= date;
        Isclosed= isclosed;
        Description= desc;
       severity = serv;
    }
    private static readonly List<Ticket> _Tickets = new();
    public static List<Ticket> GetTicketsList() => _Tickets;

}
