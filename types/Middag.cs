namespace dotnetcore_hoved.types
{
    public class Middag
    {
        public string Navn { get; set; }
        public int Vanskelighetsgrad { get; set;}
        public Middag(string navn, int vanskelighetsgrad)
        {
            Navn = navn;
            Vanskelighetsgrad = vanskelighetsgrad;
        }
    }
}