namespace DemoEkzamenAPI.DB
{
    public partial class User
    {
        public int idUser { get; set; }


        public int Password { get; set; }

        public string Login { get; set; }

        //public virtual ICollection<Rack> Racks { get; set; } = new List<Rack>();
    }
}
