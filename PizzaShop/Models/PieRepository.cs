namespace PizzaShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly List<Pie> _Pies = new();
        public List<Pie> AllPies
        {
            get { return _Pies; }
            set { _Pies.AddRange(value); }
        }
        public Pie? GetPieById(int PieID)
        {
            return AllPies.Find(pie=>pie.PieID == PieID);
        }
        
        public PieRepository () 
        {
            _Pies.Add(new Pie(1, "Pita s jabukama", "Mala pita s jabukama",(decimal)1.25,false,true));
            _Pies.Add(new Pie(2, "Makovnjaca", "Velika strudla s makom", (decimal)8.35, true, true));
            _Pies.Add(new Pie(3, "Burek", "Mastan burek sa sirom", (decimal)6.5, false, true));
            Console.WriteLine(_Pies);

        }
    }
}
