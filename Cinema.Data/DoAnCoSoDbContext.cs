using Cinema.Model.Models;
using System.Data.Entity;

namespace Cinema.Data
{
    public class DoAnCoSoDbContext : DbContext
    {
        public DoAnCoSoDbContext() : base("DoAnCoSoConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; //Load bảng cha ko include bảng con
        }

        //Khai báo các bảng
       
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Movie> Movies { set; get; }
        public DbSet<MovieCategory> MovieCategories { set; get; }
        public DbSet<MovieTag> MovieTags { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Theater> Theaters { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Food> Foods { set; get; }
        public DbSet<Time> Times { set; get; }
        public DbSet<ShowTime> ShowTimes { set; get; }

        //Ghi đè phương thức DbContext
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}